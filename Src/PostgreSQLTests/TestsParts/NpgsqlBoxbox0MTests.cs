

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.700573881574839d,right: 0.9353913636625002d,bottom: 0.12325901080690416d,left: 0.029408985063493875d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5208987167999365d,right: 0.20062433676261304d,bottom: 0.12120329503616978d,left: 0.19703094611744532d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.675963433300734d,right: 0.9657644605680062d,bottom: 0.6425872353642641d,left: 0.10507206737458075d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7847402532804882d,right: 0.3520842276849596d,bottom: 0.24231870563620928d,left: 0.13157021707092642d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6800859126779008d,right: 0.6487204637836813d,bottom: 0.2768917353080447d,left: 0.1630570603865681d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6722796836975028d,right: 0.5693743104265657d,bottom: 0.28552458203906395d,left: 0.5251635419728748d),
},
            new NpgsqlBoxbox0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5142831839578196d,right: 0.3129027410533721d,bottom: 0.4452214999868981d,left: 0.08074705249175662d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6563746564270537d,right: 0.8773768651897949d,bottom: 0.3914551477528654d,left: 0.7209418413795703d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7630845955705791d,right: 0.3972978332193512d,bottom: 0.6242128010340996d,left: 0.09620889350868911d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.795847891562634d,right: 0.30603706781901596d,bottom: 0.5101357988100205d,left: 0.05694148199350546d),
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8860119734537851d,right: 0.2965104350675758d,bottom: 0.10962805579732604d,left: 0.018393052724350545d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.34718718586339026d,right: 0.6561310742852824d,bottom: 0.0005251670138790576d,left: 0.6431360816787147d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5517810858387134d,right: 0.9794163579632763d,bottom: 0.019868127399103597d,left: 0.9076606028602672d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7591504239393891d,right: 0.6796591226536071d,bottom: 0.08661330706737813d,left: 0.4067218011763869d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8846461335127976d,right: 0.7388498330033739d,bottom: 0.020636859479917002d,left: 0.1298354110796257d),
},
            new NpgsqlBoxbox0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5372169558453577d,right: 0.6545401960117821d,bottom: 0.3457733634895087d,left: 0.6001108453346033d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4456326298011323d,right: 0.482002663526904d,bottom: 0.24859143660858618d,left: 0.1740815477135207d),
},
            new NpgsqlBoxbox0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7998159676006339d,right: 0.28835365035216787d,bottom: 0.5338375580561867d,left: 0.13299234560487427d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.618209283239839d,right: 0.8176839775574307d,bottom: 0.09249258252275006d,left: 0.4210848489398388d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6409097973758484d,right: 0.3770702155966891d,bottom: 0.5966955748167069d,left: 0.0014426390864688d),
},
            new NpgsqlBoxbox0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5676526792936345d,right: 0.8736675361159204d,bottom: 0.31864672314956d,left: 0.4894520815520027d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.39243033435532804d,right: 0.07805707072602175d,bottom: 0.2558351513066499d,left: 0.019830338862615537d),
},
            new NpgsqlBoxbox0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.922014934001807d,right: 0.46315114884540776d,bottom: 0.8261776040647644d,left: 0.35660476294536725d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7305674736893425d,right: 0.556166803913918d,bottom: 0.10705852908291968d,left: 0.5426034121762432d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8852548357433028d,right: 0.8099801312251703d,bottom: 0.22431877398265443d,left: 0.620576834414984d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9265110268382389d,right: 0.24310001848275664d,bottom: 0.8683120568527443d,left: 0.1182742871930148d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8228520434714033d,right: 0.25409653206155924d,bottom: 0.5447869030581669d,left: 0.052933323066073346d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9521480805826201d,right: 0.2937295685488248d,bottom: 0.5069430276252433d,left: 0.16065612701767373d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3396981251419783d,right: 0.23820632930189445d,bottom: 0.25738988615306957d,left: 0.030177546471842343d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8319871163672455d,right: 0.28359544521737035d,bottom: 0.2993633115104991d,left: 0.03208855569048619d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9768940760790803d,right: 0.9008868460907865d,bottom: 0.08711356273843074d,left: 0.08861716676363118d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8718081650380494d,right: 0.8827746167044054d,bottom: 0.044864948935642746d,left: 0.6467908579572667d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6689750145895078d,right: 0.9182912241209417d,bottom: 0.6024865583615251d,left: 0.4599630590539344d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2596811651555264d,right: 0.7888623947297514d,bottom: 0.1581438261667174d,left: 0.527397378001768d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.534203887464974d,right: 0.7926517920940714d,bottom: 0.019440217971152807d,left: 0.5926900487873796d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7227314114990646d,right: 0.552777848029026d,bottom: 0.31786303632576784d,left: 0.17630901263228116d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.775409021840056d,right: 0.924127584067769d,bottom: 0.38140857796285355d,left: 0.5024466946895663d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9531607647457242d,right: 0.7914973420629043d,bottom: 0.5241772901983465d,left: 0.018245268700034623d),
},
            new NpgsqlBoxbox0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8769238413274054d,right: 0.9902419308926489d,bottom: 0.7091507543913432d,left: 0.08942216876005393d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9547382739500266d,right: 0.7490955622413404d,bottom: 0.7776036762131295d,left: 0.5686384429446668d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.73322792322599d,right: 0.5081119906877957d,bottom: 0.205008664772371d,left: 0.18240481361527683d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9515576280663881d,right: 0.6960245641541873d,bottom: 0.06652704717673097d,left: 0.3015457144972399d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9532888704366529d,right: 0.871847186315339d,bottom: 0.4510918603835261d,left: 0.817054688818814d),
},
            new NpgsqlBoxbox0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6612149778720018d,right: 0.6319181206373674d,bottom: 0.06212695920008282d,left: 0.4413432327346468d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9774037162727586d,right: 0.7377084571489592d,bottom: 0.644890542589998d,left: 0.28801168340324645d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8127305257784169d,right: 0.1454906651185428d,bottom: 0.3449381019382046d,left: 0.11123507768831942d),
},
            new NpgsqlBoxbox0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6388801868737986d,right: 0.572467641860175d,bottom: 0.28679676800738707d,left: 0.4729523786776263d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3658534857697041d,right: 0.7802979973542632d,bottom: 0.18026041018888395d,left: 0.37896095611842084d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9591979323602129d,right: 0.8334694236799085d,bottom: 0.6639209960857695d,left: 0.19008241381007507d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.2868051665625486d,right: 0.8315897530380887d,bottom: 0.11886791974642685d,left: 0.5419005853696937d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.293799687865716d,right: 0.9789571278297039d,bottom: 0.07411108151006474d,left: 0.6003315411734723d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8921368766537511d,right: 0.836896050675845d,bottom: 0.7504054696256246d,left: 0.47987450303238455d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9844251537630448d,right: 0.9201057423800789d,bottom: 0.7630886946193695d,left: 0.5463398852913768d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.37186798349900696d,right: 0.7339900857220335d,bottom: 0.12807213610339008d,left: 0.6612090882369429d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9832244681675448d,right: 0.5384196930982563d,bottom: 0.26189073222979364d,left: 0.3386743558502594d),
},
            new NpgsqlBoxbox0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7362107416977223d,right: 0.18626835275201403d,bottom: 0.6155243373828783d,left: 0.04628756541647927d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7150061860126392d,right: 0.5089567489170258d,bottom: 0.4060505855131107d,left: 0.10063828665376406d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7831952252427986d,right: 0.9536063342095339d,bottom: 0.20437242869185734d,left: 0.6660411798946172d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6158846698625203d,right: 0.808546344545058d,bottom: 0.2669015707210828d,left: 0.17007962589991188d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7066607308949642d,right: 0.5826406865962295d,bottom: 0.38106725206862524d,left: 0.44297008313675723d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3600825254308687d,right: 0.8464081793846844d,bottom: 0.06963226715312243d,left: 0.7306226373172756d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6228071040875007d,right: 0.852677418545951d,bottom: 0.4135775732798761d,left: 0.4217040806453578d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.745650661178141d,right: 0.5395140659067964d,bottom: 0.5999102373637121d,left: 0.26011031976473087d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7194127249968352d,right: 0.4289463674582753d,bottom: 0.7157736637412195d,left: 0.09824157408791145d),
},
            new NpgsqlBoxbox0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9553146427773842d,right: 0.6117886070272377d,bottom: 0.8942589833536171d,left: 0.2575723583879431d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8117836159662839d,right: 0.5226815792236404d,bottom: 0.3535258454865001d,left: 0.04428045054253582d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.25931079601585005d,right: 0.8461374111965962d,bottom: 0.07976961809850913d,left: 0.044051551174646875d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7597362953398689d,right: 0.3715957413315769d,bottom: 0.10853146062213803d,left: 0.3463256510005508d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9137669362017127d,right: 0.704387204734529d,bottom: 0.6446585977710855d,left: 0.6178683373633509d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9509650478011269d,right: 0.9587298543887784d,bottom: 0.6741023344307752d,left: 0.6737029263081687d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7071435598967962d,right: 0.7596122533221691d,bottom: 0.28373545619901386d,left: 0.7299726783196742d),
},
            new NpgsqlBoxbox0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.12721956001981838d,right: 0.8422287374171028d,bottom: 0.07155661658224521d,left: 0.1858428400324853d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5765455884658872d,right: 0.9296635738611394d,bottom: 0.37383719570010865d,left: 0.0845633314521731d),
},
            new NpgsqlBoxbox0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6731531023178333d,right: 0.48859149846573735d,bottom: 0.46617205959836594d,left: 0.237613431973005d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3054467961778986d,right: 0.8777559905913662d,bottom: 0.1029585570573972d,left: 0.3557657669798038d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.24488632302742963d,right: 0.2837677425012932d,bottom: 0.06684960169773324d,left: 0.15480044422333983d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7471006384678764d,right: 0.5839777985806832d,bottom: 0.02723408002223693d,left: 0.5602303763593006d),
},
            new NpgsqlBoxbox0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7524302198656828d,right: 0.7613657153801165d,bottom: 0.08800068390106552d,left: 0.3967767198646238d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8028013889821305d,right: 0.27550278426130004d,bottom: 0.7528155342993222d,left: 0.13823590497486005d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8846461335127976d,right: 0.7388498330033739d,bottom: 0.020636859479917002d,left: 0.1298354110796257d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4456326298011323d,right: 0.482002663526904d,bottom: 0.24859143660858618d,left: 0.1740815477135207d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6409097973758484d,right: 0.3770702155966891d,bottom: 0.5966955748167069d,left: 0.0014426390864688d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.39243033435532804d,right: 0.07805707072602175d,bottom: 0.2558351513066499d,left: 0.019830338862615537d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 65;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 98;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 76, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 163, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 156, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 107, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 34, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.700573881574839d,right: 0.9353913636625002d,bottom: 0.12325901080690416d,left: 0.029408985063493875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5208987167999365d,right: 0.20062433676261304d,bottom: 0.12120329503616978d,left: 0.19703094611744532d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.675963433300734d,right: 0.9657644605680062d,bottom: 0.6425872353642641d,left: 0.10507206737458075d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7847402532804882d,right: 0.3520842276849596d,bottom: 0.24231870563620928d,left: 0.13157021707092642d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6800859126779008d,right: 0.6487204637836813d,bottom: 0.2768917353080447d,left: 0.1630570603865681d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6722796836975028d,right: 0.5693743104265657d,bottom: 0.28552458203906395d,left: 0.5251635419728748d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5142831839578196d,right: 0.3129027410533721d,bottom: 0.4452214999868981d,left: 0.08074705249175662d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6563746564270537d,right: 0.8773768651897949d,bottom: 0.3914551477528654d,left: 0.7209418413795703d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7630845955705791d,right: 0.3972978332193512d,bottom: 0.6242128010340996d,left: 0.09620889350868911d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.795847891562634d,right: 0.30603706781901596d,bottom: 0.5101357988100205d,left: 0.05694148199350546d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8860119734537851d,right: 0.2965104350675758d,bottom: 0.10962805579732604d,left: 0.018393052724350545d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34718718586339026d,right: 0.6561310742852824d,bottom: 0.0005251670138790576d,left: 0.6431360816787147d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5517810858387134d,right: 0.9794163579632763d,bottom: 0.019868127399103597d,left: 0.9076606028602672d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7591504239393891d,right: 0.6796591226536071d,bottom: 0.08661330706737813d,left: 0.4067218011763869d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8846461335127976d,right: 0.7388498330033739d,bottom: 0.020636859479917002d,left: 0.1298354110796257d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5372169558453577d,right: 0.6545401960117821d,bottom: 0.3457733634895087d,left: 0.6001108453346033d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4456326298011323d,right: 0.482002663526904d,bottom: 0.24859143660858618d,left: 0.1740815477135207d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7998159676006339d,right: 0.28835365035216787d,bottom: 0.5338375580561867d,left: 0.13299234560487427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.618209283239839d,right: 0.8176839775574307d,bottom: 0.09249258252275006d,left: 0.4210848489398388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6409097973758484d,right: 0.3770702155966891d,bottom: 0.5966955748167069d,left: 0.0014426390864688d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5676526792936345d,right: 0.8736675361159204d,bottom: 0.31864672314956d,left: 0.4894520815520027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.39243033435532804d,right: 0.07805707072602175d,bottom: 0.2558351513066499d,left: 0.019830338862615537d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.922014934001807d,right: 0.46315114884540776d,bottom: 0.8261776040647644d,left: 0.35660476294536725d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7305674736893425d,right: 0.556166803913918d,bottom: 0.10705852908291968d,left: 0.5426034121762432d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8852548357433028d,right: 0.8099801312251703d,bottom: 0.22431877398265443d,left: 0.620576834414984d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9265110268382389d,right: 0.24310001848275664d,bottom: 0.8683120568527443d,left: 0.1182742871930148d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8228520434714033d,right: 0.25409653206155924d,bottom: 0.5447869030581669d,left: 0.052933323066073346d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9521480805826201d,right: 0.2937295685488248d,bottom: 0.5069430276252433d,left: 0.16065612701767373d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3396981251419783d,right: 0.23820632930189445d,bottom: 0.25738988615306957d,left: 0.030177546471842343d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8319871163672455d,right: 0.28359544521737035d,bottom: 0.2993633115104991d,left: 0.03208855569048619d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9768940760790803d,right: 0.9008868460907865d,bottom: 0.08711356273843074d,left: 0.08861716676363118d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8718081650380494d,right: 0.8827746167044054d,bottom: 0.044864948935642746d,left: 0.6467908579572667d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6689750145895078d,right: 0.9182912241209417d,bottom: 0.6024865583615251d,left: 0.4599630590539344d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2596811651555264d,right: 0.7888623947297514d,bottom: 0.1581438261667174d,left: 0.527397378001768d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.534203887464974d,right: 0.7926517920940714d,bottom: 0.019440217971152807d,left: 0.5926900487873796d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7227314114990646d,right: 0.552777848029026d,bottom: 0.31786303632576784d,left: 0.17630901263228116d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.775409021840056d,right: 0.924127584067769d,bottom: 0.38140857796285355d,left: 0.5024466946895663d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9531607647457242d,right: 0.7914973420629043d,bottom: 0.5241772901983465d,left: 0.018245268700034623d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8769238413274054d,right: 0.9902419308926489d,bottom: 0.7091507543913432d,left: 0.08942216876005393d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9547382739500266d,right: 0.7490955622413404d,bottom: 0.7776036762131295d,left: 0.5686384429446668d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.73322792322599d,right: 0.5081119906877957d,bottom: 0.205008664772371d,left: 0.18240481361527683d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9515576280663881d,right: 0.6960245641541873d,bottom: 0.06652704717673097d,left: 0.3015457144972399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9532888704366529d,right: 0.871847186315339d,bottom: 0.4510918603835261d,left: 0.817054688818814d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6612149778720018d,right: 0.6319181206373674d,bottom: 0.06212695920008282d,left: 0.4413432327346468d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9774037162727586d,right: 0.7377084571489592d,bottom: 0.644890542589998d,left: 0.28801168340324645d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8127305257784169d,right: 0.1454906651185428d,bottom: 0.3449381019382046d,left: 0.11123507768831942d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6388801868737986d,right: 0.572467641860175d,bottom: 0.28679676800738707d,left: 0.4729523786776263d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3658534857697041d,right: 0.7802979973542632d,bottom: 0.18026041018888395d,left: 0.37896095611842084d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9591979323602129d,right: 0.8334694236799085d,bottom: 0.6639209960857695d,left: 0.19008241381007507d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2868051665625486d,right: 0.8315897530380887d,bottom: 0.11886791974642685d,left: 0.5419005853696937d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.293799687865716d,right: 0.9789571278297039d,bottom: 0.07411108151006474d,left: 0.6003315411734723d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8921368766537511d,right: 0.836896050675845d,bottom: 0.7504054696256246d,left: 0.47987450303238455d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9844251537630448d,right: 0.9201057423800789d,bottom: 0.7630886946193695d,left: 0.5463398852913768d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.37186798349900696d,right: 0.7339900857220335d,bottom: 0.12807213610339008d,left: 0.6612090882369429d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9832244681675448d,right: 0.5384196930982563d,bottom: 0.26189073222979364d,left: 0.3386743558502594d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7362107416977223d,right: 0.18626835275201403d,bottom: 0.6155243373828783d,left: 0.04628756541647927d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7150061860126392d,right: 0.5089567489170258d,bottom: 0.4060505855131107d,left: 0.10063828665376406d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7831952252427986d,right: 0.9536063342095339d,bottom: 0.20437242869185734d,left: 0.6660411798946172d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6158846698625203d,right: 0.808546344545058d,bottom: 0.2669015707210828d,left: 0.17007962589991188d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7066607308949642d,right: 0.5826406865962295d,bottom: 0.38106725206862524d,left: 0.44297008313675723d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3600825254308687d,right: 0.8464081793846844d,bottom: 0.06963226715312243d,left: 0.7306226373172756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6228071040875007d,right: 0.852677418545951d,bottom: 0.4135775732798761d,left: 0.4217040806453578d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.745650661178141d,right: 0.5395140659067964d,bottom: 0.5999102373637121d,left: 0.26011031976473087d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7194127249968352d,right: 0.4289463674582753d,bottom: 0.7157736637412195d,left: 0.09824157408791145d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9553146427773842d,right: 0.6117886070272377d,bottom: 0.8942589833536171d,left: 0.2575723583879431d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8117836159662839d,right: 0.5226815792236404d,bottom: 0.3535258454865001d,left: 0.04428045054253582d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25931079601585005d,right: 0.8461374111965962d,bottom: 0.07976961809850913d,left: 0.044051551174646875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7597362953398689d,right: 0.3715957413315769d,bottom: 0.10853146062213803d,left: 0.3463256510005508d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9137669362017127d,right: 0.704387204734529d,bottom: 0.6446585977710855d,left: 0.6178683373633509d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9509650478011269d,right: 0.9587298543887784d,bottom: 0.6741023344307752d,left: 0.6737029263081687d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7071435598967962d,right: 0.7596122533221691d,bottom: 0.28373545619901386d,left: 0.7299726783196742d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.12721956001981838d,right: 0.8422287374171028d,bottom: 0.07155661658224521d,left: 0.1858428400324853d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5765455884658872d,right: 0.9296635738611394d,bottom: 0.37383719570010865d,left: 0.0845633314521731d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6731531023178333d,right: 0.48859149846573735d,bottom: 0.46617205959836594d,left: 0.237613431973005d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3054467961778986d,right: 0.8777559905913662d,bottom: 0.1029585570573972d,left: 0.3557657669798038d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24488632302742963d,right: 0.2837677425012932d,bottom: 0.06684960169773324d,left: 0.15480044422333983d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7471006384678764d,right: 0.5839777985806832d,bottom: 0.02723408002223693d,left: 0.5602303763593006d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7524302198656828d,right: 0.7613657153801165d,bottom: 0.08800068390106552d,left: 0.3967767198646238d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8028013889821305d,right: 0.27550278426130004d,bottom: 0.7528155342993222d,left: 0.13823590497486005d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.700573881574839d,right: 0.9353913636625002d,bottom: 0.12325901080690416d,left: 0.029408985063493875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5208987167999365d,right: 0.20062433676261304d,bottom: 0.12120329503616978d,left: 0.19703094611744532d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.675963433300734d,right: 0.9657644605680062d,bottom: 0.6425872353642641d,left: 0.10507206737458075d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7847402532804882d,right: 0.3520842276849596d,bottom: 0.24231870563620928d,left: 0.13157021707092642d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6800859126779008d,right: 0.6487204637836813d,bottom: 0.2768917353080447d,left: 0.1630570603865681d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6722796836975028d,right: 0.5693743104265657d,bottom: 0.28552458203906395d,left: 0.5251635419728748d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5142831839578196d,right: 0.3129027410533721d,bottom: 0.4452214999868981d,left: 0.08074705249175662d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6563746564270537d,right: 0.8773768651897949d,bottom: 0.3914551477528654d,left: 0.7209418413795703d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7630845955705791d,right: 0.3972978332193512d,bottom: 0.6242128010340996d,left: 0.09620889350868911d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.795847891562634d,right: 0.30603706781901596d,bottom: 0.5101357988100205d,left: 0.05694148199350546d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8860119734537851d,right: 0.2965104350675758d,bottom: 0.10962805579732604d,left: 0.018393052724350545d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34718718586339026d,right: 0.6561310742852824d,bottom: 0.0005251670138790576d,left: 0.6431360816787147d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5517810858387134d,right: 0.9794163579632763d,bottom: 0.019868127399103597d,left: 0.9076606028602672d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7591504239393891d,right: 0.6796591226536071d,bottom: 0.08661330706737813d,left: 0.4067218011763869d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8846461335127976d,right: 0.7388498330033739d,bottom: 0.020636859479917002d,left: 0.1298354110796257d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5372169558453577d,right: 0.6545401960117821d,bottom: 0.3457733634895087d,left: 0.6001108453346033d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4456326298011323d,right: 0.482002663526904d,bottom: 0.24859143660858618d,left: 0.1740815477135207d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7998159676006339d,right: 0.28835365035216787d,bottom: 0.5338375580561867d,left: 0.13299234560487427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.618209283239839d,right: 0.8176839775574307d,bottom: 0.09249258252275006d,left: 0.4210848489398388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6409097973758484d,right: 0.3770702155966891d,bottom: 0.5966955748167069d,left: 0.0014426390864688d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5676526792936345d,right: 0.8736675361159204d,bottom: 0.31864672314956d,left: 0.4894520815520027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.39243033435532804d,right: 0.07805707072602175d,bottom: 0.2558351513066499d,left: 0.019830338862615537d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.922014934001807d,right: 0.46315114884540776d,bottom: 0.8261776040647644d,left: 0.35660476294536725d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7305674736893425d,right: 0.556166803913918d,bottom: 0.10705852908291968d,left: 0.5426034121762432d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8852548357433028d,right: 0.8099801312251703d,bottom: 0.22431877398265443d,left: 0.620576834414984d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9265110268382389d,right: 0.24310001848275664d,bottom: 0.8683120568527443d,left: 0.1182742871930148d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8228520434714033d,right: 0.25409653206155924d,bottom: 0.5447869030581669d,left: 0.052933323066073346d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9521480805826201d,right: 0.2937295685488248d,bottom: 0.5069430276252433d,left: 0.16065612701767373d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3396981251419783d,right: 0.23820632930189445d,bottom: 0.25738988615306957d,left: 0.030177546471842343d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8319871163672455d,right: 0.28359544521737035d,bottom: 0.2993633115104991d,left: 0.03208855569048619d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9768940760790803d,right: 0.9008868460907865d,bottom: 0.08711356273843074d,left: 0.08861716676363118d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8718081650380494d,right: 0.8827746167044054d,bottom: 0.044864948935642746d,left: 0.6467908579572667d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6689750145895078d,right: 0.9182912241209417d,bottom: 0.6024865583615251d,left: 0.4599630590539344d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2596811651555264d,right: 0.7888623947297514d,bottom: 0.1581438261667174d,left: 0.527397378001768d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.534203887464974d,right: 0.7926517920940714d,bottom: 0.019440217971152807d,left: 0.5926900487873796d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7227314114990646d,right: 0.552777848029026d,bottom: 0.31786303632576784d,left: 0.17630901263228116d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.775409021840056d,right: 0.924127584067769d,bottom: 0.38140857796285355d,left: 0.5024466946895663d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9531607647457242d,right: 0.7914973420629043d,bottom: 0.5241772901983465d,left: 0.018245268700034623d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8769238413274054d,right: 0.9902419308926489d,bottom: 0.7091507543913432d,left: 0.08942216876005393d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9547382739500266d,right: 0.7490955622413404d,bottom: 0.7776036762131295d,left: 0.5686384429446668d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.73322792322599d,right: 0.5081119906877957d,bottom: 0.205008664772371d,left: 0.18240481361527683d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9515576280663881d,right: 0.6960245641541873d,bottom: 0.06652704717673097d,left: 0.3015457144972399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9532888704366529d,right: 0.871847186315339d,bottom: 0.4510918603835261d,left: 0.817054688818814d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6612149778720018d,right: 0.6319181206373674d,bottom: 0.06212695920008282d,left: 0.4413432327346468d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9774037162727586d,right: 0.7377084571489592d,bottom: 0.644890542589998d,left: 0.28801168340324645d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8127305257784169d,right: 0.1454906651185428d,bottom: 0.3449381019382046d,left: 0.11123507768831942d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6388801868737986d,right: 0.572467641860175d,bottom: 0.28679676800738707d,left: 0.4729523786776263d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3658534857697041d,right: 0.7802979973542632d,bottom: 0.18026041018888395d,left: 0.37896095611842084d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9591979323602129d,right: 0.8334694236799085d,bottom: 0.6639209960857695d,left: 0.19008241381007507d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2868051665625486d,right: 0.8315897530380887d,bottom: 0.11886791974642685d,left: 0.5419005853696937d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.293799687865716d,right: 0.9789571278297039d,bottom: 0.07411108151006474d,left: 0.6003315411734723d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8921368766537511d,right: 0.836896050675845d,bottom: 0.7504054696256246d,left: 0.47987450303238455d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9844251537630448d,right: 0.9201057423800789d,bottom: 0.7630886946193695d,left: 0.5463398852913768d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.37186798349900696d,right: 0.7339900857220335d,bottom: 0.12807213610339008d,left: 0.6612090882369429d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9832244681675448d,right: 0.5384196930982563d,bottom: 0.26189073222979364d,left: 0.3386743558502594d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7362107416977223d,right: 0.18626835275201403d,bottom: 0.6155243373828783d,left: 0.04628756541647927d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7150061860126392d,right: 0.5089567489170258d,bottom: 0.4060505855131107d,left: 0.10063828665376406d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7831952252427986d,right: 0.9536063342095339d,bottom: 0.20437242869185734d,left: 0.6660411798946172d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6158846698625203d,right: 0.808546344545058d,bottom: 0.2669015707210828d,left: 0.17007962589991188d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7066607308949642d,right: 0.5826406865962295d,bottom: 0.38106725206862524d,left: 0.44297008313675723d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3600825254308687d,right: 0.8464081793846844d,bottom: 0.06963226715312243d,left: 0.7306226373172756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6228071040875007d,right: 0.852677418545951d,bottom: 0.4135775732798761d,left: 0.4217040806453578d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.745650661178141d,right: 0.5395140659067964d,bottom: 0.5999102373637121d,left: 0.26011031976473087d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7194127249968352d,right: 0.4289463674582753d,bottom: 0.7157736637412195d,left: 0.09824157408791145d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9553146427773842d,right: 0.6117886070272377d,bottom: 0.8942589833536171d,left: 0.2575723583879431d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8117836159662839d,right: 0.5226815792236404d,bottom: 0.3535258454865001d,left: 0.04428045054253582d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25931079601585005d,right: 0.8461374111965962d,bottom: 0.07976961809850913d,left: 0.044051551174646875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7597362953398689d,right: 0.3715957413315769d,bottom: 0.10853146062213803d,left: 0.3463256510005508d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9137669362017127d,right: 0.704387204734529d,bottom: 0.6446585977710855d,left: 0.6178683373633509d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9509650478011269d,right: 0.9587298543887784d,bottom: 0.6741023344307752d,left: 0.6737029263081687d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7071435598967962d,right: 0.7596122533221691d,bottom: 0.28373545619901386d,left: 0.7299726783196742d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.12721956001981838d,right: 0.8422287374171028d,bottom: 0.07155661658224521d,left: 0.1858428400324853d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5765455884658872d,right: 0.9296635738611394d,bottom: 0.37383719570010865d,left: 0.0845633314521731d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6731531023178333d,right: 0.48859149846573735d,bottom: 0.46617205959836594d,left: 0.237613431973005d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3054467961778986d,right: 0.8777559905913662d,bottom: 0.1029585570573972d,left: 0.3557657669798038d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24488632302742963d,right: 0.2837677425012932d,bottom: 0.06684960169773324d,left: 0.15480044422333983d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7471006384678764d,right: 0.5839777985806832d,bottom: 0.02723408002223693d,left: 0.5602303763593006d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7524302198656828d,right: 0.7613657153801165d,bottom: 0.08800068390106552d,left: 0.3967767198646238d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8028013889821305d,right: 0.27550278426130004d,bottom: 0.7528155342993222d,left: 0.13823590497486005d))));

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

