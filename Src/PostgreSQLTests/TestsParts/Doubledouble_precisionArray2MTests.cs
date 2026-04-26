

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10142429518225715d,

0.47325521957817895d,

0.26332596333700586d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8576033185250624d,

0.13986670249260946d,

0.18148368070675913d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6682642742988459d,

0.5795556224202867d,

0.06918229551194699d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39500334477922094d,

0.7589178087090797d,

0.17658404017046192d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4130140083532151d,

0.3400473535523708d,

0.11314792879001101d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3516632650674485d,

0.12079103659700985d,

0.9045045688753911d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10836497752817986d,

0.0007316495327214234d,

0.20937589354767572d,

0.8701100836860878d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3657427713461059d,

0.9630352267539557d,

0.8952148862070703d,

0.7947408322526933d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.30286322076679384d,

0.7302934931039964d,

0.7928356583392796d,

0.427409948106929d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3244899486000855d,

0.40880359976313707d,

0.5862175101558059d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12622029389759082d,

0.762134334571416d,

0.9809596903413643d,

0.5336872708198801d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2380475658039879d,

0.816513842273225d,

0.1750452052915331d,

0.8574873065368371d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9293653664755624d,

0.9731473135562992d,

0.6108463733484301d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3404678046672438d,

0.8985169662603338d,

0.6611485886854948d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26291262932348836d,

0.12950114239706612d,

0.8182704840837337d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3559323309152814d,

0.043802833499011595d,

0.9337905783946276d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9962099519239883d,

0.9472689445260024d,

0.4181247892275486d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4069861851322879d,

0.8567119523257216d,

0.5474705105424404d,

0.4819329438802402d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8947127662419225d,

0.6103019966699266d,

0.5311082199998901d,

0.053571759306965006d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3960221371926621d,

0.9527625093214039d,

0.34643628047050645d,

0.46966356487844607d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08060212871500905d,

0.6570846168592598d,

0.008467747550405691d,

0.951075982890379d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8952456743016632d,

0.3614283998089365d,

0.4412850915732127d,

0.05679552176486735d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6948804119861592d,

0.331805534842181d,

0.392473838179772d,

0.13320801079829736d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1930253200704145d,

0.20968580886373345d,

0.4851106968590245d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35339155690161805d,

0.26519915029490326d,

0.4123284173073274d,

0.9976797299366764d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48360375074924056d,

0.7507293963105977d,

0.4108845201907936d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.32553670506715915d,

0.4120491332969727d,

0.8702467673825246d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9729222246056188d,

0.08340357384132269d,

0.8036464220327372d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.18488409085858049d,

0.31337012740211645d,

0.40245270397410393d,

0.3608947778197681d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10495644543165938d,

0.4790756776706372d,

0.10488221897435268d,

0.8753167564624038d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1577424248998186d,

0.24391655390373723d,

0.3874778515069025d,

0.17825454571711252d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8977577801576816d,

0.4323418796313627d,

0.8294516978585523d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.16234464222134282d,

0.038065994185707996d,

0.7668437967762957d,

0.699133242418151d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.14970389862551758d,

0.03437414574737496d,

0.71987013368382d,

0.2201617106644812d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09348420010302716d,

0.6690816406082922d,

0.7217481307912313d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9362894212952754d,

0.42544076848080836d,

0.9247169081846635d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.25948801325549864d,

0.5052112778930434d,

0.7324554411023128d,

0.14777499173609998d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26465408242074917d,

0.7226422230012356d,

0.36437549623228627d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5565117050855491d,

0.7055501856009387d,

0.10610446826502229d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2736809791658392d,

0.4899919960790512d,

0.8846174067272008d,

0.4405364022762467d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.054243243486824744d,

0.2802435759906189d,

0.030311359741531874d,

0.6317425892111972d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2641247335112846d,

0.8248592562245909d,

0.39526122708967426d,

0.6733845546442114d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4541984373330825d,

0.1822943240503513d,

0.8498786019248484d,

0.7694134444117957d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.28424378361836433d,

0.050586190238495976d,

0.014440021603605913d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21185647053585954d,

0.7667366476020179d,

0.9057019882375188d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9080962413804411d,

0.4603015641275604d,

0.5435393244220282d,

0.8708182158262753d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.048811286870288684d,

0.29091178219903446d,

0.2552717158618455d,

0.18738296765233142d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.15665956014400217d,

0.44951807682550093d,

0.16585475682525153d,

0.5484215674012172d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.690194525585645d,

0.6539913641980123d,

0.28361236687507496d,

0.7638901913676014d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06470916916257174d,

0.6644860158712605d,

0.6365533700791723d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8910980143930602d,

0.48106153300965904d,

0.08730592475491183d,

0.24895133910280343d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.028997876201287576d,

0.152013302167474d,

0.9219831910799722d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2955305655577388d,

0.5437178817564895d,

0.6938784333309842d,

0.2050954364452262d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.017325881888056283d,

0.23202479207150772d,

0.5723160868605441d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1124129610809691d,

0.9872593350177734d,

0.4627573683967341d,

0.5412131761783855d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6997785205210002d,

0.5606021855535092d,

0.07091222351190118d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8567028861950444d,

0.8756519764149558d,

0.034979140325200775d,

0.31839335270955904d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1798758668465441d,

0.45535394441903865d,

0.7973864950113875d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.915710307441879d,

0.20813395625349584d,

0.17515455604057062d,

0.05881334228299939d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9839552625663711d,

0.3580838664316127d,

0.5492111870776655d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.34749602349288866d,

0.7483725547829553d,

0.28800713226959596d,

0.3531465535918329d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9684367845615568d,

0.5595143114307695d,

0.5711418348401581d,

0.13575340292299654d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.933110815060021d,

0.033314222526377724d,

0.250497067047014d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.26068216035236613d,

0.09995578454355669d,

0.2731100522092553d,

0.15927282927991304d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5917546946688554d,

0.7261411681554452d,

0.6675535968195508d,

0.3469226269117409d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7863279973253264d,

0.48359951807757795d,

0.20731455800236787d,

0.5582784530499705d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9340638695848682d,

0.40839588887161826d,

0.07868894451604513d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.682059051901494d,

0.518127428829981d,

0.9546353363663028d,

0.3818805747385082d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 106, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 136, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 126, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 136, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

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
                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

