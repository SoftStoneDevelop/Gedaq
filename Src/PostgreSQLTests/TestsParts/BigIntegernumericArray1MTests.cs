

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2996811862806776057L),
new System.Numerics.BigInteger(3936105137155653549L),
new System.Numerics.BigInteger(5985295529909472122L),
new System.Numerics.BigInteger(1080802857138387059L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3250299678056694929L),
new System.Numerics.BigInteger(3551571480429040225L),
new System.Numerics.BigInteger(3024383172827377727L),
new System.Numerics.BigInteger(3019300751732062985L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2595403689778640297L),
new System.Numerics.BigInteger(7277920330772127809L),
new System.Numerics.BigInteger(4167295485622923890L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7460955517328915098L),
new System.Numerics.BigInteger(5355591029599570671L),
new System.Numerics.BigInteger(6473805798279851697L),
new System.Numerics.BigInteger(2734448478817916573L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7902255936542378424L),
new System.Numerics.BigInteger(1760622748048334023L),
new System.Numerics.BigInteger(7805903703505193299L),
new System.Numerics.BigInteger(5271870435101917835L),
},
},
            new BigIntegernumericArray1M
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5628453067046485855L),
new System.Numerics.BigInteger(7446791941100053006L),
new System.Numerics.BigInteger(2045961012715465294L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1078205184228200323L),
new System.Numerics.BigInteger(7031587441796870219L),
new System.Numerics.BigInteger(8861891328143188719L),
new System.Numerics.BigInteger(1186605142385972294L),
},
},
            new BigIntegernumericArray1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2583500557576222771L),
new System.Numerics.BigInteger(338465997184130813L),
new System.Numerics.BigInteger(6959244417566967139L),
new System.Numerics.BigInteger(4517679656867258820L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1752293842303086573L),
new System.Numerics.BigInteger(180795288219827564L),
new System.Numerics.BigInteger(5572831165953819140L),
new System.Numerics.BigInteger(5204211818949407907L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2205197440978656439L),
new System.Numerics.BigInteger(7140006412514987159L),
new System.Numerics.BigInteger(5102718440974737881L),
new System.Numerics.BigInteger(6797002650848599329L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 34,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6779570650573363408L),
new System.Numerics.BigInteger(8889023933339265511L),
new System.Numerics.BigInteger(2413677607863912151L),
new System.Numerics.BigInteger(5114454821375535689L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8248867982571410055L),
new System.Numerics.BigInteger(7141292020123288366L),
new System.Numerics.BigInteger(949993666683901409L),
new System.Numerics.BigInteger(2182075373324925336L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6246102998112148438L),
new System.Numerics.BigInteger(8279227635208679001L),
new System.Numerics.BigInteger(2648476720812168489L),
new System.Numerics.BigInteger(2791142044156273144L),
},
},
            new BigIntegernumericArray1M
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1138942739714661396L),
new System.Numerics.BigInteger(7851754571960610172L),
new System.Numerics.BigInteger(6648884200763856906L),
new System.Numerics.BigInteger(3814160383790161366L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4446342784074657813L),
new System.Numerics.BigInteger(4382897221856893328L),
new System.Numerics.BigInteger(2304985941615396062L),
new System.Numerics.BigInteger(1026825877464018500L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7244556134597578361L),
new System.Numerics.BigInteger(8631696120435830078L),
new System.Numerics.BigInteger(39379636517974901L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(351841583121131700L),
new System.Numerics.BigInteger(5170879846980529568L),
new System.Numerics.BigInteger(824066428784352394L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8289098945165422026L),
new System.Numerics.BigInteger(8607879058244760452L),
new System.Numerics.BigInteger(1751527844807145043L),
},
},
            new BigIntegernumericArray1M
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(924034206651900252L),
new System.Numerics.BigInteger(3218623012918814263L),
new System.Numerics.BigInteger(4079413272122686800L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1637279775400992396L),
new System.Numerics.BigInteger(4921444440019699549L),
new System.Numerics.BigInteger(8982465429397727284L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5604028834652257931L),
new System.Numerics.BigInteger(8755350479402886317L),
new System.Numerics.BigInteger(1934536931491446365L),
new System.Numerics.BigInteger(1394170596592142785L),
},
},
            new BigIntegernumericArray1M
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4586977129633927793L),
new System.Numerics.BigInteger(5320573745059298341L),
new System.Numerics.BigInteger(1584280345633763843L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9030763921014175523L),
new System.Numerics.BigInteger(159589370441175791L),
new System.Numerics.BigInteger(5304007261096450726L),
},
},
            new BigIntegernumericArray1M
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5166386034275381719L),
new System.Numerics.BigInteger(4363583730346208316L),
new System.Numerics.BigInteger(3876345752266331952L),
new System.Numerics.BigInteger(3562726461755723579L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4458614377175087082L),
new System.Numerics.BigInteger(1320612759603712795L),
new System.Numerics.BigInteger(3154855688598141858L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7492201192401940747L),
new System.Numerics.BigInteger(7589252504335727013L),
new System.Numerics.BigInteger(7741349918217487285L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6230485511223010435L),
new System.Numerics.BigInteger(5201896473157220579L),
new System.Numerics.BigInteger(5708803372821106420L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(833343390179602988L),
new System.Numerics.BigInteger(7566503514356544442L),
new System.Numerics.BigInteger(6468435099646906849L),
},
},
            new BigIntegernumericArray1M
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(253416484353054272L),
new System.Numerics.BigInteger(5243802262134117864L),
new System.Numerics.BigInteger(5869676277121971352L),
new System.Numerics.BigInteger(9200973229805417589L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5272994701442511061L),
new System.Numerics.BigInteger(774234960566822980L),
new System.Numerics.BigInteger(5411241051608601396L),
new System.Numerics.BigInteger(4438886068275828856L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4118122050391555642L),
new System.Numerics.BigInteger(6369361333550238344L),
new System.Numerics.BigInteger(6836197031336811504L),
new System.Numerics.BigInteger(823618068855029877L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6254506971969064360L),
new System.Numerics.BigInteger(5918901365231178591L),
new System.Numerics.BigInteger(5005965920783862091L),
new System.Numerics.BigInteger(7512444111371144696L),
},
},
            new BigIntegernumericArray1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8510870083234475222L),
new System.Numerics.BigInteger(8466687547943294931L),
new System.Numerics.BigInteger(8390477779924404944L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(225201885117081688L),
new System.Numerics.BigInteger(4589840159221153183L),
new System.Numerics.BigInteger(3285148390662621609L),
new System.Numerics.BigInteger(2129961457930681158L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3958745653471172779L),
new System.Numerics.BigInteger(7673485445047719836L),
new System.Numerics.BigInteger(7458058104695394329L),
new System.Numerics.BigInteger(8132816997820274935L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6046129642460075832L),
new System.Numerics.BigInteger(8695887934540998571L),
new System.Numerics.BigInteger(5647671383549023550L),
new System.Numerics.BigInteger(2457326235089899013L),
},
},
            new BigIntegernumericArray1M
{
    Id = 94,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7111414247420514144L),
new System.Numerics.BigInteger(5995869006153255548L),
new System.Numerics.BigInteger(4523991553657876820L),
new System.Numerics.BigInteger(757961287810478441L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1341457272455218680L),
new System.Numerics.BigInteger(3376291561014409224L),
new System.Numerics.BigInteger(7526392663675026030L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5451216251094463525L),
new System.Numerics.BigInteger(5293858563729586179L),
new System.Numerics.BigInteger(5701057062554857479L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(811397494941714478L),
new System.Numerics.BigInteger(408109224980041641L),
new System.Numerics.BigInteger(8960592461030807142L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 102,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6402784022468883659L),
new System.Numerics.BigInteger(2765935733833898511L),
new System.Numerics.BigInteger(6833712562051575315L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5261716279696532267L),
new System.Numerics.BigInteger(3507582707110323530L),
new System.Numerics.BigInteger(2360217043357458340L),
new System.Numerics.BigInteger(8751057135394182649L),
},
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4288565757974237952L),
new System.Numerics.BigInteger(8528405884067826745L),
new System.Numerics.BigInteger(5364955955873172712L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6531728723028773904L),
new System.Numerics.BigInteger(7155994549610328715L),
new System.Numerics.BigInteger(2751957430102269716L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7640553692136072945L),
new System.Numerics.BigInteger(1958865821681693416L),
new System.Numerics.BigInteger(5622995878567058784L),
new System.Numerics.BigInteger(4720019125645948142L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2713633401804571165L),
new System.Numerics.BigInteger(902871953630418825L),
new System.Numerics.BigInteger(6135615152025128169L),
new System.Numerics.BigInteger(1174192797339442615L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 124,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5523088598363643841L),
new System.Numerics.BigInteger(8780401552810518760L),
new System.Numerics.BigInteger(5973564553238829078L),
new System.Numerics.BigInteger(1254779852494548149L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8150994155706914617L),
new System.Numerics.BigInteger(6844543487686016311L),
new System.Numerics.BigInteger(8990220955866731900L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4602563511749998746L),
new System.Numerics.BigInteger(8007290718343163488L),
new System.Numerics.BigInteger(3220217710645278509L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(758054194887910617L),
new System.Numerics.BigInteger(5070853149733359160L),
new System.Numerics.BigInteger(457850859604148351L),
new System.Numerics.BigInteger(83964714831278074L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1075793982933889739L),
new System.Numerics.BigInteger(1710962543134136719L),
new System.Numerics.BigInteger(1274685895014194637L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3696663173699305567L),
new System.Numerics.BigInteger(3099312805072492781L),
new System.Numerics.BigInteger(386983182993037085L),
new System.Numerics.BigInteger(2009178714608541400L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2106460749951636133L),
new System.Numerics.BigInteger(4145187460794899731L),
new System.Numerics.BigInteger(4471916886446911691L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3617470767008363620L),
new System.Numerics.BigInteger(5014355325057822549L),
new System.Numerics.BigInteger(3478517099209779911L),
},
},
            new BigIntegernumericArray1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(473316418706833507L),
new System.Numerics.BigInteger(6461484272225632534L),
new System.Numerics.BigInteger(8861157957809527360L),
new System.Numerics.BigInteger(6979489849507994038L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8064147368753394178L),
new System.Numerics.BigInteger(1101345625987394873L),
new System.Numerics.BigInteger(5503338843261671846L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1400425098517799556L),
new System.Numerics.BigInteger(7127309857131760879L),
new System.Numerics.BigInteger(562647863778162299L),
new System.Numerics.BigInteger(2197303195029587592L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 146,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7168029241125039807L),
new System.Numerics.BigInteger(2697097243777899489L),
new System.Numerics.BigInteger(5832233434666670621L),
new System.Numerics.BigInteger(2318318722732480157L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 148,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1561110916361601727L),
new System.Numerics.BigInteger(8460389574976015345L),
new System.Numerics.BigInteger(4549087552973901481L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6857573051020569545L),
new System.Numerics.BigInteger(3363574904991862631L),
new System.Numerics.BigInteger(143613857026581147L),
new System.Numerics.BigInteger(795024432112937137L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5613798375467861717L),
new System.Numerics.BigInteger(1523213871023602933L),
new System.Numerics.BigInteger(5668374653349457405L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 156,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8290122724870469669L),
new System.Numerics.BigInteger(4928245863851372713L),
new System.Numerics.BigInteger(5208083821400341336L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8852173255488366924L),
new System.Numerics.BigInteger(4526900568250308513L),
new System.Numerics.BigInteger(1264756693035368486L),
},
},
            new BigIntegernumericArray1M
{
    Id = 164,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5226452634635966985L),
new System.Numerics.BigInteger(4272787899732772374L),
new System.Numerics.BigInteger(5063940034098114027L),
new System.Numerics.BigInteger(4720156614715106955L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1601234876703591383L),
new System.Numerics.BigInteger(1475283178517502577L),
new System.Numerics.BigInteger(3838634324209135242L),
new System.Numerics.BigInteger(9024873174700888236L),
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
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 70;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 148, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 148, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 148, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 146, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
BigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
BigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray1M>(15);

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
                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[21],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[22],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[23],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[24],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[25],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[26],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[27],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[28],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

