

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region TestData

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.056149678935961456d, b: 0.31199190998237325d, c: 0.849675771524026d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21029005067483442d, b: 0.8042200189320996d, c: 0.38071607857292145d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3244156738281332d, b: 0.404800338825546d, c: 0.4541462956071728d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.10311436686523279d, b: 0.051616558118308786d, c: 0.9898710492586869d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14711355266412451d, b: 0.9636593466337221d, c: 0.2900073580641678d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5067379063354069d, b: 0.7834767780900086d, c: 0.2850843599852845d),
},
            new NpgsqlLineline0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8565032982142095d, b: 0.7888570150434547d, c: 0.024658798238569646d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5077747785822525d, b: 0.6148266629056609d, c: 0.7189605765362027d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4623265273620992d, b: 0.5689201207009424d, c: 0.21892398379541533d),
},
            new NpgsqlLineline0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12329484848149963d, b: 0.28687645299922937d, c: 0.511316766658841d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1463947139930709d, b: 0.328800792096993d, c: 0.6147034629070309d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2030997103706278d, b: 0.8425371302539989d, c: 0.4441810090189394d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.32452139146938785d, b: 0.19059854949238397d, c: 0.37864069450880544d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3954410325908664d, b: 0.17036307876360435d, c: 0.7158459827855173d),
},
            new NpgsqlLineline0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9898407744358803d, b: 0.4377562173132318d, c: 0.6400177595251287d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9432827490676929d, b: 0.5778897904088907d, c: 0.31434557065115587d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.07812200345186371d, b: 0.8925786115870213d, c: 0.27503063094660285d),
},
            new NpgsqlLineline0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.29076981998799223d, b: 0.03864536650245376d, c: 0.2537581085905114d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5004837536745638d, b: 0.9275585016922109d, c: 0.7941658731532155d),
},
            new NpgsqlLineline0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6966619331112077d, b: 0.5803060433949724d, c: 0.32368517586739887d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07865854493430235d, b: 0.13640776848469371d, c: 0.7642450478176523d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8216514754069888d, b: 0.7535684032581542d, c: 0.6086743442700692d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4051525670796394d, b: 0.05586007837491613d, c: 0.5972163780548189d),
},
            new NpgsqlLineline0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.768657871279438d, b: 0.5587462670529771d, c: 0.7641684277023928d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3563046921792883d, b: 0.8132276955184484d, c: 0.18385481006881588d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2964569954870834d, b: 0.07086242280230726d, c: 0.4667891451848881d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2775258680158187d, b: 0.9691238074687508d, c: 0.40495193580705235d),
},
            new NpgsqlLineline0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.30636409879216475d, b: 0.271687548260632d, c: 0.519966107183437d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3390099788206131d, b: 0.47332283400836306d, c: 0.790794528108005d),
},
            new NpgsqlLineline0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.518079720407951d, b: 0.41437064989155903d, c: 0.026624284954748d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45243740919763553d, b: 0.44753002292559874d, c: 0.12661685688310909d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.21550441329996106d, b: 0.2695896352905667d, c: 0.6715553616735916d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13260664339686767d, b: 0.8656136296205271d, c: 0.28471618043179736d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5259540158002346d, b: 0.0729790805965248d, c: 0.4267634336800371d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2091815250335215d, b: 0.9583403284835755d, c: 0.05663331554016282d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.14597722161685334d, b: 0.1762542862211638d, c: 0.9599634994054028d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9311634264668136d, b: 0.9734334194015338d, c: 0.6863072877317542d),
},
            new NpgsqlLineline0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20496080976022546d, b: 0.004999965148772212d, c: 0.8238501465798963d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8950431000403674d, b: 0.2928330270439282d, c: 0.8446915988008794d),
},
            new NpgsqlLineline0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.36670164074008427d, b: 0.667719184063809d, c: 0.7753746773953392d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.33692198954471064d, b: 0.5348712823535597d, c: 0.14104087432535062d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14932060373627853d, b: 0.4982569341605869d, c: 0.849488428506423d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07077147965082253d, b: 0.4688506342125631d, c: 0.4287176173566142d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.36358725786373514d, b: 0.92866773351059d, c: 0.39112202801438634d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7554845726112268d, b: 0.7873730901718784d, c: 0.2969985026390295d),
},
            new NpgsqlLineline0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.568659773277021d, b: 0.6667999847905327d, c: 0.5877150085277634d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5593313681105374d, b: 0.9804480091379776d, c: 0.8437160670745628d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.017000439555397873d, b: 0.7563963941746401d, c: 0.8586086424255079d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8120614295004481d, b: 0.5856937188713403d, c: 0.6920794478588875d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9760265331478569d, b: 0.2060239703268586d, c: 0.917123274909339d),
},
            new NpgsqlLineline0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.601855011174003d, b: 0.8310898632148243d, c: 0.7459533769387611d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.42108353559736733d, b: 0.4741429064865561d, c: 0.024107055603703742d),
},
            new NpgsqlLineline0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6290791460793451d, b: 0.8720020326097997d, c: 0.6393397221338296d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.762976013588641d, b: 0.6931784595029463d, c: 0.30921147643592806d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.45196656858780504d, b: 0.8453020359084614d, c: 0.23080039915183492d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.039372270651095276d, b: 0.2594482902564509d, c: 0.9977333038974437d),
},
            new NpgsqlLineline0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9676284648508824d, b: 0.04636553565848567d, c: 0.13577032601685213d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4091861596468762d, b: 0.8805133446261227d, c: 0.5962191331182197d),
},
            new NpgsqlLineline0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9775398635314391d, b: 0.6948988430426418d, c: 0.3489875951741094d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8984317718792675d, b: 0.3416200884131224d, c: 0.5171278490766993d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5248259786438412d, b: 0.2487461534471862d, c: 0.21086901248851053d),
},
            new NpgsqlLineline0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.09951490660750684d, b: 0.6676422654341624d, c: 0.2091737143908059d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19753304580929143d, b: 0.22854856248376743d, c: 0.813739744653752d),
},
            new NpgsqlLineline0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.036258946324489005d, b: 0.49672033415202177d, c: 0.2957175517892988d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9225405223886413d, b: 0.3282849665439246d, c: 0.5445849918498183d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.01672942318389925d, b: 0.34351340425895294d, c: 0.9287314845251082d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13121758941965556d, b: 0.14898518999036459d, c: 0.7809878973534685d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6361575407823314d, b: 0.4459162347238632d, c: 0.32405149162997604d),
},
            new NpgsqlLineline0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5681505524400184d, b: 0.587434794841791d, c: 0.38121841111507526d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6512793039385727d, b: 0.4768100748917069d, c: 0.7741855610178798d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5259883813797549d, b: 0.07639388942811376d, c: 0.24792715954755273d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.27272287800205397d, b: 0.5713766596399731d, c: 0.6466781774004072d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.03911837581869926d, b: 0.4667577488647213d, c: 0.17524410605310503d),
},
            new NpgsqlLineline0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.49074488116006987d, b: 0.43946437971274466d, c: 0.48667753542650427d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8158883996779963d, b: 0.40188474289714826d, c: 0.7214912730731831d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6902679685708352d, b: 0.3853111887868095d, c: 0.2028133276592653d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5012557011521477d, b: 0.8111922170796704d, c: 0.14511154813948313d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4064044019005464d, b: 0.8988714349589995d, c: 0.3601821788767794d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6555283262266334d, b: 0.8773730465545733d, c: 0.649899442542849d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.540514496312978d, b: 0.22735919492799195d, c: 0.5171427907477046d),
},
            new NpgsqlLineline0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.27282957981912115d, b: 0.09444112343863098d, c: 0.7786894281404221d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3395286476318736d, b: 0.2162047288292337d, c: 0.1811225813191848d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3954410325908664d, b: 0.17036307876360435d, c: 0.7158459827855173d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07812200345186371d, b: 0.8925786115870213d, c: 0.27503063094660285d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5004837536745638d, b: 0.9275585016922109d, c: 0.7941658731532155d)));
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4051525670796394d, b: 0.05586007837491613d, c: 0.5972163780548189d)));
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2775258680158187d, b: 0.9691238074687508d, c: 0.40495193580705235d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 166, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 49, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 136, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 113, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));
NpgsqlLineline0M.AssertModel(models[0],_testData[4], false);NpgsqlLineline0M.AssertModel(models[1],_testData[5], false);NpgsqlLineline0M.AssertModel(models[2],_testData[6], false);NpgsqlLineline0M.AssertModel(models[3],_testData[7], false);NpgsqlLineline0M.AssertModel(models[4],_testData[8], false);NpgsqlLineline0M.AssertModel(models[5],_testData[9], false);NpgsqlLineline0M.AssertModel(models[6],_testData[10], false);NpgsqlLineline0M.AssertModel(models[7],_testData[11], false);NpgsqlLineline0M.AssertModel(models[8],_testData[12], false);NpgsqlLineline0M.AssertModel(models[9],_testData[13], false);NpgsqlLineline0M.AssertModel(models[10],_testData[14], false);NpgsqlLineline0M.AssertModel(models[11],_testData[15], false);NpgsqlLineline0M.AssertModel(models[12],_testData[16], false);NpgsqlLineline0M.AssertModel(models[13],_testData[17], false);NpgsqlLineline0M.AssertModel(models[14],_testData[18], false);NpgsqlLineline0M.AssertModel(models[15],_testData[19], false);NpgsqlLineline0M.AssertModel(models[16],_testData[20], false);NpgsqlLineline0M.AssertModel(models[17],_testData[21], false);NpgsqlLineline0M.AssertModel(models[18],_testData[22], false);NpgsqlLineline0M.AssertModel(models[19],_testData[23], false);NpgsqlLineline0M.AssertModel(models[20],_testData[24], false);NpgsqlLineline0M.AssertModel(models[21],_testData[25], false);NpgsqlLineline0M.AssertModel(models[22],_testData[26], false);NpgsqlLineline0M.AssertModel(models[23],_testData[27], false);NpgsqlLineline0M.AssertModel(models[24],_testData[28], false);NpgsqlLineline0M.AssertModel(models[25],_testData[29], false);NpgsqlLineline0M.AssertModel(models[26],_testData[30], false);NpgsqlLineline0M.AssertModel(models[27],_testData[31], false);NpgsqlLineline0M.AssertModel(models[28],_testData[32], false);NpgsqlLineline0M.AssertModel(models[29],_testData[33], false);NpgsqlLineline0M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));
NpgsqlLineline0M.AssertModel(models[0],_testData[4], false);NpgsqlLineline0M.AssertModel(models[1],_testData[5], false);NpgsqlLineline0M.AssertModel(models[2],_testData[6], false);NpgsqlLineline0M.AssertModel(models[3],_testData[7], false);NpgsqlLineline0M.AssertModel(models[4],_testData[8], false);NpgsqlLineline0M.AssertModel(models[5],_testData[9], false);NpgsqlLineline0M.AssertModel(models[6],_testData[10], false);NpgsqlLineline0M.AssertModel(models[7],_testData[11], false);NpgsqlLineline0M.AssertModel(models[8],_testData[12], false);NpgsqlLineline0M.AssertModel(models[9],_testData[13], false);NpgsqlLineline0M.AssertModel(models[10],_testData[14], false);NpgsqlLineline0M.AssertModel(models[11],_testData[15], false);NpgsqlLineline0M.AssertModel(models[12],_testData[16], false);NpgsqlLineline0M.AssertModel(models[13],_testData[17], false);NpgsqlLineline0M.AssertModel(models[14],_testData[18], false);NpgsqlLineline0M.AssertModel(models[15],_testData[19], false);NpgsqlLineline0M.AssertModel(models[16],_testData[20], false);NpgsqlLineline0M.AssertModel(models[17],_testData[21], false);NpgsqlLineline0M.AssertModel(models[18],_testData[22], false);NpgsqlLineline0M.AssertModel(models[19],_testData[23], false);NpgsqlLineline0M.AssertModel(models[20],_testData[24], false);NpgsqlLineline0M.AssertModel(models[21],_testData[25], false);NpgsqlLineline0M.AssertModel(models[22],_testData[26], false);NpgsqlLineline0M.AssertModel(models[23],_testData[27], false);NpgsqlLineline0M.AssertModel(models[24],_testData[28], false);NpgsqlLineline0M.AssertModel(models[25],_testData[29], false);NpgsqlLineline0M.AssertModel(models[26],_testData[30], false);NpgsqlLineline0M.AssertModel(models[27],_testData[31], false);NpgsqlLineline0M.AssertModel(models[28],_testData[32], false);NpgsqlLineline0M.AssertModel(models[29],_testData[33], false);NpgsqlLineline0M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.056149678935961456d, b: 0.31199190998237325d, c: 0.849675771524026d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21029005067483442d, b: 0.8042200189320996d, c: 0.38071607857292145d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3244156738281332d, b: 0.404800338825546d, c: 0.4541462956071728d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10311436686523279d, b: 0.051616558118308786d, c: 0.9898710492586869d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14711355266412451d, b: 0.9636593466337221d, c: 0.2900073580641678d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5067379063354069d, b: 0.7834767780900086d, c: 0.2850843599852845d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8565032982142095d, b: 0.7888570150434547d, c: 0.024658798238569646d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5077747785822525d, b: 0.6148266629056609d, c: 0.7189605765362027d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4623265273620992d, b: 0.5689201207009424d, c: 0.21892398379541533d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12329484848149963d, b: 0.28687645299922937d, c: 0.511316766658841d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1463947139930709d, b: 0.328800792096993d, c: 0.6147034629070309d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2030997103706278d, b: 0.8425371302539989d, c: 0.4441810090189394d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32452139146938785d, b: 0.19059854949238397d, c: 0.37864069450880544d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3954410325908664d, b: 0.17036307876360435d, c: 0.7158459827855173d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9898407744358803d, b: 0.4377562173132318d, c: 0.6400177595251287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9432827490676929d, b: 0.5778897904088907d, c: 0.31434557065115587d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07812200345186371d, b: 0.8925786115870213d, c: 0.27503063094660285d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29076981998799223d, b: 0.03864536650245376d, c: 0.2537581085905114d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5004837536745638d, b: 0.9275585016922109d, c: 0.7941658731532155d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6966619331112077d, b: 0.5803060433949724d, c: 0.32368517586739887d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07865854493430235d, b: 0.13640776848469371d, c: 0.7642450478176523d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8216514754069888d, b: 0.7535684032581542d, c: 0.6086743442700692d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4051525670796394d, b: 0.05586007837491613d, c: 0.5972163780548189d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.768657871279438d, b: 0.5587462670529771d, c: 0.7641684277023928d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3563046921792883d, b: 0.8132276955184484d, c: 0.18385481006881588d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2964569954870834d, b: 0.07086242280230726d, c: 0.4667891451848881d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2775258680158187d, b: 0.9691238074687508d, c: 0.40495193580705235d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.30636409879216475d, b: 0.271687548260632d, c: 0.519966107183437d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3390099788206131d, b: 0.47332283400836306d, c: 0.790794528108005d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.518079720407951d, b: 0.41437064989155903d, c: 0.026624284954748d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45243740919763553d, b: 0.44753002292559874d, c: 0.12661685688310909d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21550441329996106d, b: 0.2695896352905667d, c: 0.6715553616735916d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13260664339686767d, b: 0.8656136296205271d, c: 0.28471618043179736d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5259540158002346d, b: 0.0729790805965248d, c: 0.4267634336800371d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2091815250335215d, b: 0.9583403284835755d, c: 0.05663331554016282d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14597722161685334d, b: 0.1762542862211638d, c: 0.9599634994054028d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9311634264668136d, b: 0.9734334194015338d, c: 0.6863072877317542d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20496080976022546d, b: 0.004999965148772212d, c: 0.8238501465798963d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8950431000403674d, b: 0.2928330270439282d, c: 0.8446915988008794d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36670164074008427d, b: 0.667719184063809d, c: 0.7753746773953392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33692198954471064d, b: 0.5348712823535597d, c: 0.14104087432535062d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14932060373627853d, b: 0.4982569341605869d, c: 0.849488428506423d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07077147965082253d, b: 0.4688506342125631d, c: 0.4287176173566142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36358725786373514d, b: 0.92866773351059d, c: 0.39112202801438634d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7554845726112268d, b: 0.7873730901718784d, c: 0.2969985026390295d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.568659773277021d, b: 0.6667999847905327d, c: 0.5877150085277634d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5593313681105374d, b: 0.9804480091379776d, c: 0.8437160670745628d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.017000439555397873d, b: 0.7563963941746401d, c: 0.8586086424255079d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8120614295004481d, b: 0.5856937188713403d, c: 0.6920794478588875d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9760265331478569d, b: 0.2060239703268586d, c: 0.917123274909339d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.601855011174003d, b: 0.8310898632148243d, c: 0.7459533769387611d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42108353559736733d, b: 0.4741429064865561d, c: 0.024107055603703742d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6290791460793451d, b: 0.8720020326097997d, c: 0.6393397221338296d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.762976013588641d, b: 0.6931784595029463d, c: 0.30921147643592806d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45196656858780504d, b: 0.8453020359084614d, c: 0.23080039915183492d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.039372270651095276d, b: 0.2594482902564509d, c: 0.9977333038974437d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9676284648508824d, b: 0.04636553565848567d, c: 0.13577032601685213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4091861596468762d, b: 0.8805133446261227d, c: 0.5962191331182197d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9775398635314391d, b: 0.6948988430426418d, c: 0.3489875951741094d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8984317718792675d, b: 0.3416200884131224d, c: 0.5171278490766993d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5248259786438412d, b: 0.2487461534471862d, c: 0.21086901248851053d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09951490660750684d, b: 0.6676422654341624d, c: 0.2091737143908059d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19753304580929143d, b: 0.22854856248376743d, c: 0.813739744653752d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.036258946324489005d, b: 0.49672033415202177d, c: 0.2957175517892988d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9225405223886413d, b: 0.3282849665439246d, c: 0.5445849918498183d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.01672942318389925d, b: 0.34351340425895294d, c: 0.9287314845251082d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13121758941965556d, b: 0.14898518999036459d, c: 0.7809878973534685d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6361575407823314d, b: 0.4459162347238632d, c: 0.32405149162997604d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5681505524400184d, b: 0.587434794841791d, c: 0.38121841111507526d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6512793039385727d, b: 0.4768100748917069d, c: 0.7741855610178798d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5259883813797549d, b: 0.07639388942811376d, c: 0.24792715954755273d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27272287800205397d, b: 0.5713766596399731d, c: 0.6466781774004072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03911837581869926d, b: 0.4667577488647213d, c: 0.17524410605310503d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49074488116006987d, b: 0.43946437971274466d, c: 0.48667753542650427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8158883996779963d, b: 0.40188474289714826d, c: 0.7214912730731831d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6902679685708352d, b: 0.3853111887868095d, c: 0.2028133276592653d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5012557011521477d, b: 0.8111922170796704d, c: 0.14511154813948313d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4064044019005464d, b: 0.8988714349589995d, c: 0.3601821788767794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6555283262266334d, b: 0.8773730465545733d, c: 0.649899442542849d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.540514496312978d, b: 0.22735919492799195d, c: 0.5171427907477046d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27282957981912115d, b: 0.09444112343863098d, c: 0.7786894281404221d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3395286476318736d, b: 0.2162047288292337d, c: 0.1811225813191848d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.056149678935961456d, b: 0.31199190998237325d, c: 0.849675771524026d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21029005067483442d, b: 0.8042200189320996d, c: 0.38071607857292145d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3244156738281332d, b: 0.404800338825546d, c: 0.4541462956071728d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10311436686523279d, b: 0.051616558118308786d, c: 0.9898710492586869d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14711355266412451d, b: 0.9636593466337221d, c: 0.2900073580641678d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5067379063354069d, b: 0.7834767780900086d, c: 0.2850843599852845d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8565032982142095d, b: 0.7888570150434547d, c: 0.024658798238569646d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5077747785822525d, b: 0.6148266629056609d, c: 0.7189605765362027d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4623265273620992d, b: 0.5689201207009424d, c: 0.21892398379541533d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12329484848149963d, b: 0.28687645299922937d, c: 0.511316766658841d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1463947139930709d, b: 0.328800792096993d, c: 0.6147034629070309d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2030997103706278d, b: 0.8425371302539989d, c: 0.4441810090189394d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32452139146938785d, b: 0.19059854949238397d, c: 0.37864069450880544d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3954410325908664d, b: 0.17036307876360435d, c: 0.7158459827855173d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9898407744358803d, b: 0.4377562173132318d, c: 0.6400177595251287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9432827490676929d, b: 0.5778897904088907d, c: 0.31434557065115587d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07812200345186371d, b: 0.8925786115870213d, c: 0.27503063094660285d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29076981998799223d, b: 0.03864536650245376d, c: 0.2537581085905114d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5004837536745638d, b: 0.9275585016922109d, c: 0.7941658731532155d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6966619331112077d, b: 0.5803060433949724d, c: 0.32368517586739887d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07865854493430235d, b: 0.13640776848469371d, c: 0.7642450478176523d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8216514754069888d, b: 0.7535684032581542d, c: 0.6086743442700692d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4051525670796394d, b: 0.05586007837491613d, c: 0.5972163780548189d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.768657871279438d, b: 0.5587462670529771d, c: 0.7641684277023928d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3563046921792883d, b: 0.8132276955184484d, c: 0.18385481006881588d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2964569954870834d, b: 0.07086242280230726d, c: 0.4667891451848881d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2775258680158187d, b: 0.9691238074687508d, c: 0.40495193580705235d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.30636409879216475d, b: 0.271687548260632d, c: 0.519966107183437d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3390099788206131d, b: 0.47332283400836306d, c: 0.790794528108005d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.518079720407951d, b: 0.41437064989155903d, c: 0.026624284954748d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45243740919763553d, b: 0.44753002292559874d, c: 0.12661685688310909d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21550441329996106d, b: 0.2695896352905667d, c: 0.6715553616735916d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13260664339686767d, b: 0.8656136296205271d, c: 0.28471618043179736d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5259540158002346d, b: 0.0729790805965248d, c: 0.4267634336800371d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2091815250335215d, b: 0.9583403284835755d, c: 0.05663331554016282d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14597722161685334d, b: 0.1762542862211638d, c: 0.9599634994054028d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9311634264668136d, b: 0.9734334194015338d, c: 0.6863072877317542d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20496080976022546d, b: 0.004999965148772212d, c: 0.8238501465798963d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8950431000403674d, b: 0.2928330270439282d, c: 0.8446915988008794d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36670164074008427d, b: 0.667719184063809d, c: 0.7753746773953392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33692198954471064d, b: 0.5348712823535597d, c: 0.14104087432535062d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14932060373627853d, b: 0.4982569341605869d, c: 0.849488428506423d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07077147965082253d, b: 0.4688506342125631d, c: 0.4287176173566142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36358725786373514d, b: 0.92866773351059d, c: 0.39112202801438634d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7554845726112268d, b: 0.7873730901718784d, c: 0.2969985026390295d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.568659773277021d, b: 0.6667999847905327d, c: 0.5877150085277634d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5593313681105374d, b: 0.9804480091379776d, c: 0.8437160670745628d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.017000439555397873d, b: 0.7563963941746401d, c: 0.8586086424255079d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8120614295004481d, b: 0.5856937188713403d, c: 0.6920794478588875d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9760265331478569d, b: 0.2060239703268586d, c: 0.917123274909339d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.601855011174003d, b: 0.8310898632148243d, c: 0.7459533769387611d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42108353559736733d, b: 0.4741429064865561d, c: 0.024107055603703742d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6290791460793451d, b: 0.8720020326097997d, c: 0.6393397221338296d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.762976013588641d, b: 0.6931784595029463d, c: 0.30921147643592806d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45196656858780504d, b: 0.8453020359084614d, c: 0.23080039915183492d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.039372270651095276d, b: 0.2594482902564509d, c: 0.9977333038974437d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9676284648508824d, b: 0.04636553565848567d, c: 0.13577032601685213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4091861596468762d, b: 0.8805133446261227d, c: 0.5962191331182197d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9775398635314391d, b: 0.6948988430426418d, c: 0.3489875951741094d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8984317718792675d, b: 0.3416200884131224d, c: 0.5171278490766993d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5248259786438412d, b: 0.2487461534471862d, c: 0.21086901248851053d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09951490660750684d, b: 0.6676422654341624d, c: 0.2091737143908059d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19753304580929143d, b: 0.22854856248376743d, c: 0.813739744653752d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.036258946324489005d, b: 0.49672033415202177d, c: 0.2957175517892988d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9225405223886413d, b: 0.3282849665439246d, c: 0.5445849918498183d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.01672942318389925d, b: 0.34351340425895294d, c: 0.9287314845251082d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13121758941965556d, b: 0.14898518999036459d, c: 0.7809878973534685d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6361575407823314d, b: 0.4459162347238632d, c: 0.32405149162997604d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5681505524400184d, b: 0.587434794841791d, c: 0.38121841111507526d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6512793039385727d, b: 0.4768100748917069d, c: 0.7741855610178798d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5259883813797549d, b: 0.07639388942811376d, c: 0.24792715954755273d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27272287800205397d, b: 0.5713766596399731d, c: 0.6466781774004072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03911837581869926d, b: 0.4667577488647213d, c: 0.17524410605310503d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49074488116006987d, b: 0.43946437971274466d, c: 0.48667753542650427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8158883996779963d, b: 0.40188474289714826d, c: 0.7214912730731831d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6902679685708352d, b: 0.3853111887868095d, c: 0.2028133276592653d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5012557011521477d, b: 0.8111922170796704d, c: 0.14511154813948313d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4064044019005464d, b: 0.8988714349589995d, c: 0.3601821788767794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6555283262266334d, b: 0.8773730465545733d, c: 0.649899442542849d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.540514496312978d, b: 0.22735919492799195d, c: 0.5171427907477046d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27282957981912115d, b: 0.09444112343863098d, c: 0.7786894281404221d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3395286476318736d, b: 0.2162047288292337d, c: 0.1811225813191848d))));

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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

