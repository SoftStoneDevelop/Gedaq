

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
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5995318255374977d,right: 0.15984982082472166d,bottom: 0.14861314853476426d,left: 0.08140305586873098d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3087445301041699d,right: 0.4903541660948296d,bottom: 0.25139934496482785d,left: 0.2255105809764929d),
},
            new NpgsqlBoxbox0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8393665864989776d,right: 0.39294241376237526d,bottom: 0.2250245094939689d,left: 0.19283093205777135d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6681564348731543d,right: 0.9620176649487587d,bottom: 0.00706676746433188d,left: 0.277555035973416d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6016724544736086d,right: 0.2209905391039143d,bottom: 0.2310417682928625d,left: 0.033064121810515656d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4690922809104656d,right: 0.6237657883331096d,bottom: 0.18675525398563886d,left: 0.39298200104505454d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.23728345536011564d,right: 0.7940861523165086d,bottom: 0.0317373580653878d,left: 0.689905790677946d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.094992248195917d,right: 0.6081130813132948d,bottom: 0.0623649204103679d,left: 0.6077277518364228d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7420125693267117d,right: 0.9168431142417136d,bottom: 0.40111091132764d,left: 0.419816722998013d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6676812462661217d,right: 0.4372020411430789d,bottom: 0.22758208614376696d,left: 0.24280589098051641d),
},
            new NpgsqlBoxbox0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6347871262469665d,right: 0.7711377110425984d,bottom: 0.3902835744888242d,left: 0.09106370560304178d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9505298074201539d,right: 0.2379013089864107d,bottom: 0.3035100339946717d,left: 0.17564484751953424d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9790930891689803d,right: 0.07215720988503194d,bottom: 0.1637178092436724d,left: 0.03230191100590829d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.744563930607283d,right: 0.7448628101826131d,bottom: 0.44640039064973813d,left: 0.5848845857847782d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8187908547408274d,right: 0.9739584686889964d,bottom: 0.22378405705144333d,left: 0.5422364159277762d),
},
            new NpgsqlBoxbox0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8699005446040682d,right: 0.587544128154127d,bottom: 0.8537667351349807d,left: 0.33984939778063505d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9063028982746595d,right: 0.8859699893073307d,bottom: 0.6086871537424998d,left: 0.7607036500741402d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9631631420253142d,right: 0.35347260247078394d,bottom: 0.49502888451475324d,left: 0.21226689779469066d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.39527217170151974d,right: 0.8779203612345595d,bottom: 0.19206033418177482d,left: 0.31552007432956763d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5346086806718204d,right: 0.44746289669925166d,bottom: 0.3788621691740415d,left: 0.43017075343452427d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9073465032534563d,right: 0.9623618142290561d,bottom: 0.048129433022508716d,left: 0.6235660024355448d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.24500220405848794d,right: 0.9438496038994842d,bottom: 0.21382491583094165d,left: 0.4486970469333267d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5212645200885236d,right: 0.390943224276988d,bottom: 0.21618044210842124d,left: 0.28574817717115d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7694274404373926d,right: 0.782929282215847d,bottom: 0.6106981931091701d,left: 0.7006845565958979d),
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9735579230695225d,right: 0.98467336096286d,bottom: 0.2360052625550776d,left: 0.6989208162307979d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5380130329563109d,right: 0.5457940540388452d,bottom: 0.48773742096194794d,left: 0.2699163753920071d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5919037247219614d,right: 0.6947092418259089d,bottom: 0.40048149511040887d,left: 0.25436327361407407d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.45190080052505943d,right: 0.9279499652033462d,bottom: 0.13184089856656878d,left: 0.4418681171316271d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4414342248575237d,right: 0.937208723090702d,bottom: 0.3085797715752494d,left: 0.7972413187093907d),
},
            new NpgsqlBoxbox0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4629217317172798d,right: 0.44094830100953597d,bottom: 0.23627946253425014d,left: 0.11374674927745154d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5600435814394411d,right: 0.20141616294070985d,bottom: 0.43632048977173765d,left: 0.14005677511400227d),
},
            new NpgsqlBoxbox0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7986549061704998d,right: 0.8696244087243884d,bottom: 0.020429200304192485d,left: 0.47560183041909576d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9852347253113413d,right: 0.6307893838094859d,bottom: 0.39657552547971653d,left: 0.10327777763625023d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9014059850401662d,right: 0.42696007341383957d,bottom: 0.1316387206017391d,left: 0.19722318077940992d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8698223678677683d,right: 0.9724213937614252d,bottom: 0.5256652592459086d,left: 0.34967030641190644d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.650780136321815d,right: 0.6915815773182259d,bottom: 0.5885380784363948d,left: 0.051744259397932035d),
},
            new NpgsqlBoxbox0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6504728199198996d,right: 0.4928196090933501d,bottom: 0.3524549614455832d,left: 0.3832124022316342d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.684556081605637d,right: 0.9231740211040596d,bottom: 0.5849809667589566d,left: 0.5188553642951602d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7259642612211447d,right: 0.4254587335706592d,bottom: 0.4161493403589116d,left: 0.29853043154690406d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.30428994484592786d,right: 0.6401354531046294d,bottom: 0.2790367421876321d,left: 0.5222162635262715d),
},
            new NpgsqlBoxbox0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3715754463425889d,right: 0.9433796633252134d,bottom: 0.21194680379113562d,left: 0.7042902829205208d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6842623862027695d,right: 0.30887191618080445d,bottom: 0.22978532628756176d,left: 0.2655184255929477d),
},
            new NpgsqlBoxbox0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8900529130963405d,right: 0.879026109752054d,bottom: 0.336961250283046d,left: 0.26626313816657443d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9942586533168939d,right: 0.10848528563312299d,bottom: 0.3258384014303283d,left: 0.06756950802112527d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9585365018752223d,right: 0.7087029979577356d,bottom: 0.7630003832022397d,left: 0.5504108270019211d),
},
            new NpgsqlBoxbox0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.949480704747004d,right: 0.8087627142120621d,bottom: 0.7569063492569157d,left: 0.4878059040140551d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9380358892306926d,right: 0.5790388628093569d,bottom: 0.14803372144120097d,left: 0.3980492488814451d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9238475778509138d,right: 0.1754002265351231d,bottom: 0.12442571123295942d,left: 0.14754453276006285d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5279634705961417d,right: 0.4838655803851717d,bottom: 0.14234774584959975d,left: 0.34883497251300244d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8377583129409664d,right: 0.47889235023323107d,bottom: 0.2018528505972771d,left: 0.1953552474584953d),
},
            new NpgsqlBoxbox0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9723488592963421d,right: 0.4935865751746036d,bottom: 0.2314201956782258d,left: 0.43022090547770564d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9938072479366596d,right: 0.6984417828684257d,bottom: 0.8813699402352541d,left: 0.40395317572669287d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9701607196192257d,right: 0.7266405335453564d,bottom: 0.7388148338332305d,left: 0.40516072310079876d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8132326535912503d,right: 0.7856880409196072d,bottom: 0.04036468841590379d,left: 0.4475716278049353d),
},
            new NpgsqlBoxbox0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8149356295609398d,right: 0.7214012914511616d,bottom: 0.8000565389963178d,left: 0.633154315342226d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4443452229262713d,right: 0.5947671780407936d,bottom: 0.33898485993750793d,left: 0.5214392002353703d),
},
            new NpgsqlBoxbox0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5965448909473123d,right: 0.9587281954627611d,bottom: 0.06547298556007841d,left: 0.37256539451189596d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6247863750571259d,right: 0.42147776954117844d,bottom: 0.3939344229139543d,left: 0.006969061596186044d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8819553149629182d,right: 0.6432035089592391d,bottom: 0.6004566752225812d,left: 0.41967424679556564d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6562251716531792d,right: 0.9022027930074872d,bottom: 0.40362223888082227d,left: 0.3671292776391524d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.19041697188546347d,right: 0.44963258318151267d,bottom: 0.16971416739527034d,left: 0.2495320982094945d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.24768209725696133d,right: 0.542955604240297d,bottom: 0.020806907981753442d,left: 0.1195782534162626d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5560463047526278d,right: 0.9394836394841735d,bottom: 0.28078085499977945d,left: 0.4219335564487563d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5184294216076769d,right: 0.2985937401334715d,bottom: 0.1519250026948462d,left: 0.0822367991565296d),
},
            new NpgsqlBoxbox0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.27843798692283994d,right: 0.8735783330976652d,bottom: 0.2657604914269234d,left: 0.31932589641287445d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.78064649464796d,right: 0.7632965456367778d,bottom: 0.3596457826324513d,left: 0.76105263650513d),
},
            new NpgsqlBoxbox0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8245434850418086d,right: 0.9021886929032679d,bottom: 0.6584957404681626d,left: 0.2368782016867983d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6026139571813991d,right: 0.6591754122964631d,bottom: 0.04169717508011528d,left: 0.6115389497314832d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7129777878352418d,right: 0.846431286599073d,bottom: 0.6283158722894123d,left: 0.6428389985086056d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 177,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7688230455159771d,right: 0.2113275666923059d,bottom: 0.3901290555847611d,left: 0.20227442811756602d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3553277786850775d,right: 0.6313958644622287d,bottom: 0.06025016554698637d,left: 0.4036868556818781d),
    NullableValue = null,
},
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8187908547408274d,right: 0.9739584686889964d,bottom: 0.22378405705144333d,left: 0.5422364159277762d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7694274404373926d,right: 0.782929282215847d,bottom: 0.6106981931091701d,left: 0.7006845565958979d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4414342248575237d,right: 0.937208723090702d,bottom: 0.3085797715752494d,left: 0.7972413187093907d)));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 113;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 161, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[29], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 25, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 161, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 135, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5995318255374977d,right: 0.15984982082472166d,bottom: 0.14861314853476426d,left: 0.08140305586873098d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3087445301041699d,right: 0.4903541660948296d,bottom: 0.25139934496482785d,left: 0.2255105809764929d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8393665864989776d,right: 0.39294241376237526d,bottom: 0.2250245094939689d,left: 0.19283093205777135d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6681564348731543d,right: 0.9620176649487587d,bottom: 0.00706676746433188d,left: 0.277555035973416d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6016724544736086d,right: 0.2209905391039143d,bottom: 0.2310417682928625d,left: 0.033064121810515656d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4690922809104656d,right: 0.6237657883331096d,bottom: 0.18675525398563886d,left: 0.39298200104505454d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23728345536011564d,right: 0.7940861523165086d,bottom: 0.0317373580653878d,left: 0.689905790677946d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.094992248195917d,right: 0.6081130813132948d,bottom: 0.0623649204103679d,left: 0.6077277518364228d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7420125693267117d,right: 0.9168431142417136d,bottom: 0.40111091132764d,left: 0.419816722998013d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6676812462661217d,right: 0.4372020411430789d,bottom: 0.22758208614376696d,left: 0.24280589098051641d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6347871262469665d,right: 0.7711377110425984d,bottom: 0.3902835744888242d,left: 0.09106370560304178d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9505298074201539d,right: 0.2379013089864107d,bottom: 0.3035100339946717d,left: 0.17564484751953424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9790930891689803d,right: 0.07215720988503194d,bottom: 0.1637178092436724d,left: 0.03230191100590829d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.744563930607283d,right: 0.7448628101826131d,bottom: 0.44640039064973813d,left: 0.5848845857847782d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8187908547408274d,right: 0.9739584686889964d,bottom: 0.22378405705144333d,left: 0.5422364159277762d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8699005446040682d,right: 0.587544128154127d,bottom: 0.8537667351349807d,left: 0.33984939778063505d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9063028982746595d,right: 0.8859699893073307d,bottom: 0.6086871537424998d,left: 0.7607036500741402d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9631631420253142d,right: 0.35347260247078394d,bottom: 0.49502888451475324d,left: 0.21226689779469066d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.39527217170151974d,right: 0.8779203612345595d,bottom: 0.19206033418177482d,left: 0.31552007432956763d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5346086806718204d,right: 0.44746289669925166d,bottom: 0.3788621691740415d,left: 0.43017075343452427d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9073465032534563d,right: 0.9623618142290561d,bottom: 0.048129433022508716d,left: 0.6235660024355448d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24500220405848794d,right: 0.9438496038994842d,bottom: 0.21382491583094165d,left: 0.4486970469333267d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5212645200885236d,right: 0.390943224276988d,bottom: 0.21618044210842124d,left: 0.28574817717115d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7694274404373926d,right: 0.782929282215847d,bottom: 0.6106981931091701d,left: 0.7006845565958979d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9735579230695225d,right: 0.98467336096286d,bottom: 0.2360052625550776d,left: 0.6989208162307979d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5380130329563109d,right: 0.5457940540388452d,bottom: 0.48773742096194794d,left: 0.2699163753920071d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5919037247219614d,right: 0.6947092418259089d,bottom: 0.40048149511040887d,left: 0.25436327361407407d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45190080052505943d,right: 0.9279499652033462d,bottom: 0.13184089856656878d,left: 0.4418681171316271d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4414342248575237d,right: 0.937208723090702d,bottom: 0.3085797715752494d,left: 0.7972413187093907d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4629217317172798d,right: 0.44094830100953597d,bottom: 0.23627946253425014d,left: 0.11374674927745154d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5600435814394411d,right: 0.20141616294070985d,bottom: 0.43632048977173765d,left: 0.14005677511400227d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7986549061704998d,right: 0.8696244087243884d,bottom: 0.020429200304192485d,left: 0.47560183041909576d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9852347253113413d,right: 0.6307893838094859d,bottom: 0.39657552547971653d,left: 0.10327777763625023d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9014059850401662d,right: 0.42696007341383957d,bottom: 0.1316387206017391d,left: 0.19722318077940992d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8698223678677683d,right: 0.9724213937614252d,bottom: 0.5256652592459086d,left: 0.34967030641190644d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.650780136321815d,right: 0.6915815773182259d,bottom: 0.5885380784363948d,left: 0.051744259397932035d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6504728199198996d,right: 0.4928196090933501d,bottom: 0.3524549614455832d,left: 0.3832124022316342d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.684556081605637d,right: 0.9231740211040596d,bottom: 0.5849809667589566d,left: 0.5188553642951602d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7259642612211447d,right: 0.4254587335706592d,bottom: 0.4161493403589116d,left: 0.29853043154690406d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30428994484592786d,right: 0.6401354531046294d,bottom: 0.2790367421876321d,left: 0.5222162635262715d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3715754463425889d,right: 0.9433796633252134d,bottom: 0.21194680379113562d,left: 0.7042902829205208d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6842623862027695d,right: 0.30887191618080445d,bottom: 0.22978532628756176d,left: 0.2655184255929477d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8900529130963405d,right: 0.879026109752054d,bottom: 0.336961250283046d,left: 0.26626313816657443d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9942586533168939d,right: 0.10848528563312299d,bottom: 0.3258384014303283d,left: 0.06756950802112527d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9585365018752223d,right: 0.7087029979577356d,bottom: 0.7630003832022397d,left: 0.5504108270019211d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.949480704747004d,right: 0.8087627142120621d,bottom: 0.7569063492569157d,left: 0.4878059040140551d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9380358892306926d,right: 0.5790388628093569d,bottom: 0.14803372144120097d,left: 0.3980492488814451d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9238475778509138d,right: 0.1754002265351231d,bottom: 0.12442571123295942d,left: 0.14754453276006285d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5279634705961417d,right: 0.4838655803851717d,bottom: 0.14234774584959975d,left: 0.34883497251300244d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8377583129409664d,right: 0.47889235023323107d,bottom: 0.2018528505972771d,left: 0.1953552474584953d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9723488592963421d,right: 0.4935865751746036d,bottom: 0.2314201956782258d,left: 0.43022090547770564d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9938072479366596d,right: 0.6984417828684257d,bottom: 0.8813699402352541d,left: 0.40395317572669287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9701607196192257d,right: 0.7266405335453564d,bottom: 0.7388148338332305d,left: 0.40516072310079876d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8132326535912503d,right: 0.7856880409196072d,bottom: 0.04036468841590379d,left: 0.4475716278049353d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8149356295609398d,right: 0.7214012914511616d,bottom: 0.8000565389963178d,left: 0.633154315342226d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4443452229262713d,right: 0.5947671780407936d,bottom: 0.33898485993750793d,left: 0.5214392002353703d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5965448909473123d,right: 0.9587281954627611d,bottom: 0.06547298556007841d,left: 0.37256539451189596d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6247863750571259d,right: 0.42147776954117844d,bottom: 0.3939344229139543d,left: 0.006969061596186044d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8819553149629182d,right: 0.6432035089592391d,bottom: 0.6004566752225812d,left: 0.41967424679556564d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6562251716531792d,right: 0.9022027930074872d,bottom: 0.40362223888082227d,left: 0.3671292776391524d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19041697188546347d,right: 0.44963258318151267d,bottom: 0.16971416739527034d,left: 0.2495320982094945d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24768209725696133d,right: 0.542955604240297d,bottom: 0.020806907981753442d,left: 0.1195782534162626d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5560463047526278d,right: 0.9394836394841735d,bottom: 0.28078085499977945d,left: 0.4219335564487563d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5184294216076769d,right: 0.2985937401334715d,bottom: 0.1519250026948462d,left: 0.0822367991565296d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27843798692283994d,right: 0.8735783330976652d,bottom: 0.2657604914269234d,left: 0.31932589641287445d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.78064649464796d,right: 0.7632965456367778d,bottom: 0.3596457826324513d,left: 0.76105263650513d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8245434850418086d,right: 0.9021886929032679d,bottom: 0.6584957404681626d,left: 0.2368782016867983d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6026139571813991d,right: 0.6591754122964631d,bottom: 0.04169717508011528d,left: 0.6115389497314832d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7129777878352418d,right: 0.846431286599073d,bottom: 0.6283158722894123d,left: 0.6428389985086056d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7688230455159771d,right: 0.2113275666923059d,bottom: 0.3901290555847611d,left: 0.20227442811756602d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3553277786850775d,right: 0.6313958644622287d,bottom: 0.06025016554698637d,left: 0.4036868556818781d))));//InnerModel.Value

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
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5995318255374977d,right: 0.15984982082472166d,bottom: 0.14861314853476426d,left: 0.08140305586873098d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3087445301041699d,right: 0.4903541660948296d,bottom: 0.25139934496482785d,left: 0.2255105809764929d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8393665864989776d,right: 0.39294241376237526d,bottom: 0.2250245094939689d,left: 0.19283093205777135d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6681564348731543d,right: 0.9620176649487587d,bottom: 0.00706676746433188d,left: 0.277555035973416d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6016724544736086d,right: 0.2209905391039143d,bottom: 0.2310417682928625d,left: 0.033064121810515656d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4690922809104656d,right: 0.6237657883331096d,bottom: 0.18675525398563886d,left: 0.39298200104505454d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23728345536011564d,right: 0.7940861523165086d,bottom: 0.0317373580653878d,left: 0.689905790677946d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.094992248195917d,right: 0.6081130813132948d,bottom: 0.0623649204103679d,left: 0.6077277518364228d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7420125693267117d,right: 0.9168431142417136d,bottom: 0.40111091132764d,left: 0.419816722998013d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6676812462661217d,right: 0.4372020411430789d,bottom: 0.22758208614376696d,left: 0.24280589098051641d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6347871262469665d,right: 0.7711377110425984d,bottom: 0.3902835744888242d,left: 0.09106370560304178d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9505298074201539d,right: 0.2379013089864107d,bottom: 0.3035100339946717d,left: 0.17564484751953424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9790930891689803d,right: 0.07215720988503194d,bottom: 0.1637178092436724d,left: 0.03230191100590829d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.744563930607283d,right: 0.7448628101826131d,bottom: 0.44640039064973813d,left: 0.5848845857847782d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8187908547408274d,right: 0.9739584686889964d,bottom: 0.22378405705144333d,left: 0.5422364159277762d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8699005446040682d,right: 0.587544128154127d,bottom: 0.8537667351349807d,left: 0.33984939778063505d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9063028982746595d,right: 0.8859699893073307d,bottom: 0.6086871537424998d,left: 0.7607036500741402d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9631631420253142d,right: 0.35347260247078394d,bottom: 0.49502888451475324d,left: 0.21226689779469066d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.39527217170151974d,right: 0.8779203612345595d,bottom: 0.19206033418177482d,left: 0.31552007432956763d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5346086806718204d,right: 0.44746289669925166d,bottom: 0.3788621691740415d,left: 0.43017075343452427d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9073465032534563d,right: 0.9623618142290561d,bottom: 0.048129433022508716d,left: 0.6235660024355448d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24500220405848794d,right: 0.9438496038994842d,bottom: 0.21382491583094165d,left: 0.4486970469333267d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5212645200885236d,right: 0.390943224276988d,bottom: 0.21618044210842124d,left: 0.28574817717115d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7694274404373926d,right: 0.782929282215847d,bottom: 0.6106981931091701d,left: 0.7006845565958979d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9735579230695225d,right: 0.98467336096286d,bottom: 0.2360052625550776d,left: 0.6989208162307979d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5380130329563109d,right: 0.5457940540388452d,bottom: 0.48773742096194794d,left: 0.2699163753920071d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5919037247219614d,right: 0.6947092418259089d,bottom: 0.40048149511040887d,left: 0.25436327361407407d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45190080052505943d,right: 0.9279499652033462d,bottom: 0.13184089856656878d,left: 0.4418681171316271d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4414342248575237d,right: 0.937208723090702d,bottom: 0.3085797715752494d,left: 0.7972413187093907d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4629217317172798d,right: 0.44094830100953597d,bottom: 0.23627946253425014d,left: 0.11374674927745154d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5600435814394411d,right: 0.20141616294070985d,bottom: 0.43632048977173765d,left: 0.14005677511400227d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7986549061704998d,right: 0.8696244087243884d,bottom: 0.020429200304192485d,left: 0.47560183041909576d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9852347253113413d,right: 0.6307893838094859d,bottom: 0.39657552547971653d,left: 0.10327777763625023d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9014059850401662d,right: 0.42696007341383957d,bottom: 0.1316387206017391d,left: 0.19722318077940992d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8698223678677683d,right: 0.9724213937614252d,bottom: 0.5256652592459086d,left: 0.34967030641190644d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.650780136321815d,right: 0.6915815773182259d,bottom: 0.5885380784363948d,left: 0.051744259397932035d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6504728199198996d,right: 0.4928196090933501d,bottom: 0.3524549614455832d,left: 0.3832124022316342d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.684556081605637d,right: 0.9231740211040596d,bottom: 0.5849809667589566d,left: 0.5188553642951602d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7259642612211447d,right: 0.4254587335706592d,bottom: 0.4161493403589116d,left: 0.29853043154690406d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30428994484592786d,right: 0.6401354531046294d,bottom: 0.2790367421876321d,left: 0.5222162635262715d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3715754463425889d,right: 0.9433796633252134d,bottom: 0.21194680379113562d,left: 0.7042902829205208d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6842623862027695d,right: 0.30887191618080445d,bottom: 0.22978532628756176d,left: 0.2655184255929477d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8900529130963405d,right: 0.879026109752054d,bottom: 0.336961250283046d,left: 0.26626313816657443d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9942586533168939d,right: 0.10848528563312299d,bottom: 0.3258384014303283d,left: 0.06756950802112527d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9585365018752223d,right: 0.7087029979577356d,bottom: 0.7630003832022397d,left: 0.5504108270019211d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.949480704747004d,right: 0.8087627142120621d,bottom: 0.7569063492569157d,left: 0.4878059040140551d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9380358892306926d,right: 0.5790388628093569d,bottom: 0.14803372144120097d,left: 0.3980492488814451d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9238475778509138d,right: 0.1754002265351231d,bottom: 0.12442571123295942d,left: 0.14754453276006285d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5279634705961417d,right: 0.4838655803851717d,bottom: 0.14234774584959975d,left: 0.34883497251300244d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8377583129409664d,right: 0.47889235023323107d,bottom: 0.2018528505972771d,left: 0.1953552474584953d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9723488592963421d,right: 0.4935865751746036d,bottom: 0.2314201956782258d,left: 0.43022090547770564d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9938072479366596d,right: 0.6984417828684257d,bottom: 0.8813699402352541d,left: 0.40395317572669287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9701607196192257d,right: 0.7266405335453564d,bottom: 0.7388148338332305d,left: 0.40516072310079876d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8132326535912503d,right: 0.7856880409196072d,bottom: 0.04036468841590379d,left: 0.4475716278049353d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8149356295609398d,right: 0.7214012914511616d,bottom: 0.8000565389963178d,left: 0.633154315342226d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4443452229262713d,right: 0.5947671780407936d,bottom: 0.33898485993750793d,left: 0.5214392002353703d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5965448909473123d,right: 0.9587281954627611d,bottom: 0.06547298556007841d,left: 0.37256539451189596d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6247863750571259d,right: 0.42147776954117844d,bottom: 0.3939344229139543d,left: 0.006969061596186044d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8819553149629182d,right: 0.6432035089592391d,bottom: 0.6004566752225812d,left: 0.41967424679556564d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6562251716531792d,right: 0.9022027930074872d,bottom: 0.40362223888082227d,left: 0.3671292776391524d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19041697188546347d,right: 0.44963258318151267d,bottom: 0.16971416739527034d,left: 0.2495320982094945d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24768209725696133d,right: 0.542955604240297d,bottom: 0.020806907981753442d,left: 0.1195782534162626d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5560463047526278d,right: 0.9394836394841735d,bottom: 0.28078085499977945d,left: 0.4219335564487563d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5184294216076769d,right: 0.2985937401334715d,bottom: 0.1519250026948462d,left: 0.0822367991565296d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27843798692283994d,right: 0.8735783330976652d,bottom: 0.2657604914269234d,left: 0.31932589641287445d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.78064649464796d,right: 0.7632965456367778d,bottom: 0.3596457826324513d,left: 0.76105263650513d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8245434850418086d,right: 0.9021886929032679d,bottom: 0.6584957404681626d,left: 0.2368782016867983d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6026139571813991d,right: 0.6591754122964631d,bottom: 0.04169717508011528d,left: 0.6115389497314832d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7129777878352418d,right: 0.846431286599073d,bottom: 0.6283158722894123d,left: 0.6428389985086056d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7688230455159771d,right: 0.2113275666923059d,bottom: 0.3901290555847611d,left: 0.20227442811756602d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3553277786850775d,right: 0.6313958644622287d,bottom: 0.06025016554698637d,left: 0.4036868556818781d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0M>(15);

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
                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

