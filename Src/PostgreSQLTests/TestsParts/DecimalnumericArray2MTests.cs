

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.488305593931284m,

0.282868925237615m,

0.588587105104712m,

0.0964389931940369m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.849254562776257m,

0.448014180715026m,

0.929820162007629m,

0.221518038687157m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.979514345977074m,

0.262630721136881m,

0.482304446593235m,

0.9191844163995m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.850069668762985m,

0.55351940357047m,

0.0837665735901353m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.861352519700034m,

0.779506935074033m,

0.781490367739109m,

0.361336184516856m,

},
},
            new DecimalnumericArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.143981676675914m,

0.818438285211403m,

0.726051863046512m,

0.105934258214277m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.441842573892559m,

0.981479498147725m,

0.986705491584514m,

0.666009140752316m,

},
},
            new DecimalnumericArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.754766397852426m,

0.0737746163360696m,

0.548707823651507m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.410255535132584m,

0.374682089570693m,

0.0305475991099121m,

0.227716823719056m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.558691158767292m,

0.853230836412672m,

0.314740274892927m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.932701814611085m,

0.67442192525434m,

0.397116872541559m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.52330233702546m,

0.562967135528887m,

0.0577012498432323m,

0.537273061526681m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.66012623138278m,

0.72565810117559m,

0.00507047111379466m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.299248877840514m,

0.928181526441808m,

0.229018651968855m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.478827117244233m,

0.0585776134103916m,

0.379615501242918m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.00343945121308165m,

0.780007933028734m,

0.51176476607534m,

0.274690807084421m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.846282364381566m,

0.406991137467951m,

0.226152909247158m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.57091346700312m,

0.83978196585947m,

0.151794212812048m,

0.744621417723528m,

},
},
            new DecimalnumericArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.109062787503581m,

0.116714910817773m,

0.920057059198702m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.108245011970299m,

0.0254427013292077m,

0.796998782332996m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.55165724330437m,

0.260796856115877m,

0.152368616753278m,

0.520662134218935m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.870288791066796m,

0.647681908184232m,

0.386175259806764m,

0.895779534582838m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.621489864036618m,

0.68052018745687m,

0.425303134237104m,

0.864760456756617m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.296226214049217m,

0.113819589558558m,

0.985424710789522m,

0.0103410203750194m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.513040039888054m,

0.0487381403174404m,

0.932934909037303m,

0.594064311481672m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.02770162823495m,

0.49696996032382m,

0.211675059934426m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.806568531307002m,

0.710263536285107m,

0.582053074116638m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.520364713995906m,

0.681766273692725m,

0.932379826081048m,

0.145697965655812m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.634715910973108m,

0.580816187723342m,

0.0575847840758181m,

0.989074232390936m,

},
},
            new DecimalnumericArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.171370019637092m,

0.112074991114943m,

0.333897393209193m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.525405650710523m,

0.880117756481136m,

0.588859445347037m,

},
},
            new DecimalnumericArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.362816261543024m,

0.604147072134815m,

0.387793550435373m,

0.11184843851448m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.94167172117987m,

0.983491499720871m,

0.695570580076214m,

0.00202964621777935m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.274364351869036m,

0.42403812633523m,

0.875021315844489m,

},
},
            new DecimalnumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.213879306732891m,

0.753129515560954m,

0.467489311946665m,

0.24279806607895m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.397636679656168m,

0.500717014166768m,

0.119639970066305m,

},
},
            new DecimalnumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.68182847555627m,

0.619063818565157m,

0.112245902468324m,

0.280037418131931m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.992705250621745m,

0.196748563371365m,

0.209423191404736m,

0.449067052100663m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.369662532976469m,

0.389277204736728m,

0.474764905332895m,

0.910347275934592m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.760927656340588m,

0.20018789178681m,

0.740449451624765m,

},
},
            new DecimalnumericArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.25838239083487m,

0.698901763869154m,

0.0227431296099992m,

0.295791340595424m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.47852975523821m,

0.233451243176264m,

0.502394808604263m,

0.374787164891766m,

},
},
            new DecimalnumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.771106776208129m,

0.472269749340345m,

0.660411032454201m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.585048196164371m,

0.888224189924781m,

0.0762563462957755m,

0.707228954475581m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.547723314355322m,

0.50669435969834m,

0.462692956079512m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.143598405486113m,

0.311442835997487m,

0.770508266476939m,

0.900700918422501m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.470660637995572m,

0.933905068590824m,

0.584886940410589m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.440508616068242m,

0.295711290531472m,

0.882240527799775m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.01241365121078m,

0.651253325456455m,

0.111262735337329m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.690129161589023m,

0.0824126950761858m,

0.672942044198304m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.933051436843743m,

0.299539093985433m,

0.949319273433537m,

0.338681283268068m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.382846317216574m,

0.804140935109413m,

0.366074677003867m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.538680751664593m,

0.339894744097616m,

0.346357818387296m,

0.0873078535564616m,

},
},
            new DecimalnumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.118422233216419m,

0.739574455187326m,

0.996755313803486m,

0.275092665981581m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.596663175795387m,

0.886750733017741m,

0.813072540815122m,

0.136933646164172m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.714219976247129m,

0.25671297423903m,

0.454763367083908m,

0.792172929104161m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.853849895607905m,

0.768072691646492m,

0.109216490817857m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.965168215014829m,

0.094181677061993m,

0.45592384240383m,

0.357858338769452m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.813559674666008m,

0.878850314727355m,

0.342415850080131m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.261341508761487m,

0.534628819321529m,

0.968740729997323m,

0.825036183730272m,

},
},
            new DecimalnumericArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.181261542608898m,

0.0190296062449401m,

0.33123259181873m,

0.636834692460021m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.187363155402998m,

0.613559444256805m,

0.947537367241352m,

0.46483990131176m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.534972560367634m,

0.691566890062469m,

0.409921038817827m,

0.870512073186294m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0578687689497018m,

0.651379898698342m,

0.689657161437063m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.324604522197528m,

0.589933600971832m,

0.60649908827025m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 90;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 125, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 6, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 133, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 47, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 120, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 132, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
DecimalnumericArray2M.AssertModel(models[0],_testData[14], false);DecimalnumericArray2M.AssertModel(models[1],_testData[15], false);DecimalnumericArray2M.AssertModel(models[2],_testData[16], false);DecimalnumericArray2M.AssertModel(models[3],_testData[17], false);DecimalnumericArray2M.AssertModel(models[4],_testData[18], false);DecimalnumericArray2M.AssertModel(models[5],_testData[19], false);DecimalnumericArray2M.AssertModel(models[6],_testData[20], false);DecimalnumericArray2M.AssertModel(models[7],_testData[21], false);DecimalnumericArray2M.AssertModel(models[8],_testData[22], false);DecimalnumericArray2M.AssertModel(models[9],_testData[23], false);DecimalnumericArray2M.AssertModel(models[10],_testData[24], false);DecimalnumericArray2M.AssertModel(models[11],_testData[25], false);DecimalnumericArray2M.AssertModel(models[12],_testData[26], false);DecimalnumericArray2M.AssertModel(models[13],_testData[27], false);DecimalnumericArray2M.AssertModel(models[14],_testData[28], false);DecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
DecimalnumericArray2M.AssertModel(models[0],_testData[25], false);DecimalnumericArray2M.AssertModel(models[1],_testData[26], false);DecimalnumericArray2M.AssertModel(models[2],_testData[27], false);DecimalnumericArray2M.AssertModel(models[3],_testData[28], false);DecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2M>(15);

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
                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

