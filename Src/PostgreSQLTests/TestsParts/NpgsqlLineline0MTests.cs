

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
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6497316590856751d, b: 0.2948871063138445d, c: 0.6769448064204325d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8269282096405162d, b: 0.3581353200720486d, c: 0.8171476033366493d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4466163270991931d, b: 0.3316219494667978d, c: 0.5050442799976386d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5874631333482591d, b: 0.8853592715922785d, c: 0.4300764093329994d),
},
            new NpgsqlLineline0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6824388473951131d, b: 0.5258227306810888d, c: 0.43572464292388635d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9591846577801882d, b: 0.3195985197917276d, c: 0.7308060900538064d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6186137574045629d, b: 0.11531625282032698d, c: 0.13022510206974203d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.11437888285113729d, b: 0.019733107530826244d, c: 0.8579833345583695d),
},
            new NpgsqlLineline0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6838383987220168d, b: 0.9498885534568391d, c: 0.47376695193404683d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.27612107192357416d, b: 0.8987280496030561d, c: 0.39827156382135975d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9435405876611506d, b: 0.43166781195300896d, c: 0.6215874218583965d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4417890459547176d, b: 0.5800838921675441d, c: 0.7807419723694266d),
},
            new NpgsqlLineline0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6785075990115416d, b: 0.8870244921078476d, c: 0.45387064206310623d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.05594403642149193d, b: 0.9571891809735669d, c: 0.11806022755177747d),
},
            new NpgsqlLineline0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5710600819750676d, b: 0.790913336432273d, c: 0.35117038248578847d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5163716311155232d, b: 0.7940293828481338d, c: 0.6664668907815977d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08686975420521892d, b: 0.3253840095913033d, c: 0.972717897525058d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7977843300423099d, b: 0.664557839120943d, c: 0.04548315309821116d),
},
            new NpgsqlLineline0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0924294925210365d, b: 0.46557300187573725d, c: 0.20121285398778088d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9075370267553738d, b: 0.8843952581819805d, c: 0.5348673646633328d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.43900264846606196d, b: 0.27972998811107597d, c: 0.48387833826260307d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.009627915690501698d, b: 0.33665678800128007d, c: 0.5234577620638159d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18898137920151137d, b: 0.671463673448988d, c: 0.8252073701913588d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07708023788361906d, b: 0.28709973812899103d, c: 0.394333633298548d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.41523319965784833d, b: 0.04757830095315119d, c: 0.7846611149626849d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.33737948918104343d, b: 0.21810773512819326d, c: 0.33207937504106144d),
},
            new NpgsqlLineline0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2613858466587029d, b: 0.27334832051639535d, c: 0.951537092727191d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5142232702381905d, b: 0.33153377256210004d, c: 0.41488560146146913d),
},
            new NpgsqlLineline0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08599260453965551d, b: 0.055648725229942575d, c: 0.08856801268025782d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1910799390780923d, b: 0.06026487605427555d, c: 0.280272132110853d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9139424565385824d, b: 0.06407533024233192d, c: 0.2139508349646997d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7839719187733729d, b: 0.45778594267797046d, c: 0.11723588242352834d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8952595985628021d, b: 0.14747348982837372d, c: 0.3099562712891517d),
},
            new NpgsqlLineline0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6180763047852632d, b: 0.21439972754846126d, c: 0.44235403131607287d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3082610653309331d, b: 0.8455695159570745d, c: 0.5317698696225016d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8774230068240483d, b: 0.3741919987532647d, c: 0.4221433752272086d),
},
            new NpgsqlLineline0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7954605862128783d, b: 0.7765389809492408d, c: 0.07573673774896972d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5888750611107734d, b: 0.2655307049446137d, c: 0.45255200335654644d),
},
            new NpgsqlLineline0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9630607414464993d, b: 0.9612922488799095d, c: 0.6051746491172895d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.25118983536035533d, b: 0.3429841580082901d, c: 0.12282648498465809d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.04514120530378152d, b: 0.4762293870391544d, c: 0.5069666994787421d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21358720214877602d, b: 0.9475385486359701d, c: 0.7020648682917692d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7227971373166503d, b: 0.729906627523406d, c: 0.40038869604165994d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.879223596327483d, b: 0.6675336331703176d, c: 0.7073156575123405d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6561004208164708d, b: 0.9281056222810197d, c: 0.7143711186064746d),
},
            new NpgsqlLineline0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10221065402668694d, b: 0.6256012195728577d, c: 0.12030312546793875d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.92208040990725d, b: 0.6584744192030481d, c: 0.9899616542275815d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6244766573908513d, b: 0.9204318977405614d, c: 0.7251071526790428d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.33075726608768974d, b: 0.18549949440875013d, c: 0.5162875901980514d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.652488043209236d, b: 0.9136876100741007d, c: 0.7997850824970894d),
},
            new NpgsqlLineline0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5838026507553791d, b: 0.6241796179579496d, c: 0.6845207389048024d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6075046383948023d, b: 0.3232026737129914d, c: 0.4620358831685635d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6047146283692109d, b: 0.7976171196967102d, c: 0.9423376992842344d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4610499351730092d, b: 0.7409875655791842d, c: 0.2928223071232994d),
},
            new NpgsqlLineline0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8782816459970301d, b: 0.4689787654100924d, c: 0.21985204664387958d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08070089625586974d, b: 0.02844612679202485d, c: 0.41761676768110123d),
},
            new NpgsqlLineline0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.884317611297326d, b: 0.5154312985989019d, c: 0.5225952018926634d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14597865715941838d, b: 0.12283717859249099d, c: 0.2501570069105653d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.42112685099870417d, b: 0.20382600141770335d, c: 0.251467685655576d),
},
            new NpgsqlLineline0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.016551453387907422d, b: 0.0751750449161821d, c: 0.1652615611889262d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7652285799903122d, b: 0.24371082071585193d, c: 0.3268012910204918d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7674608599367725d, b: 0.5786644227713239d, c: 0.9445141932131401d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.452519054189947d, b: 0.21753843642559678d, c: 0.975192478050815d),
},
            new NpgsqlLineline0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7670937476819468d, b: 0.4958712041415393d, c: 0.15232505740173952d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8602874627112349d, b: 0.720435712676645d, c: 0.8343963725954552d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06236714196332749d, b: 0.09316032725166734d, c: 0.3918910992525374d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7980965918846082d, b: 0.6408487471926584d, c: 0.45243635219334366d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.943650346563328d, b: 0.5694514538318295d, c: 0.5686454629295425d),
},
            new NpgsqlLineline0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0929587482039479d, b: 0.180119167512531d, c: 0.5325137419391023d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4583368592509677d, b: 0.1556036142724112d, c: 0.07782825739923749d),
},
            new NpgsqlLineline0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5190496554492834d, b: 0.6407148552819351d, c: 0.050999039465874585d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8025409217918507d, b: 0.7580091237198455d, c: 0.29095428512453647d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.21800201188389123d, b: 0.06180264593386231d, c: 0.8217668702572657d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9540397731135061d, b: 0.3816952438845078d, c: 0.1763080883989886d),
},
            new NpgsqlLineline0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7282241859142399d, b: 0.16669662805900098d, c: 0.4930560182993814d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.453063568235063d, b: 0.061036812975343135d, c: 0.10938312639748216d),
},
            new NpgsqlLineline0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7499113686780727d, b: 0.7103781028822166d, c: 0.056035892541290044d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6509624277131104d, b: 0.6079963619865109d, c: 0.9886505232611053d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8450266904976526d, b: 0.12446068014974254d, c: 0.8460973907843296d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8072361615885921d, b: 0.5861414138401947d, c: 0.5356441320725627d),
},
            new NpgsqlLineline0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13583542448093333d, b: 0.3850046473346832d, c: 0.9561799815983176d),
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4417890459547176d, b: 0.5800838921675441d, c: 0.7807419723694266d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05594403642149193d, b: 0.9571891809735669d, c: 0.11806022755177747d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7977843300423099d, b: 0.664557839120943d, c: 0.04548315309821116d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33737948918104343d, b: 0.21810773512819326d, c: 0.33207937504106144d)));
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[31],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr2.Value = 3;
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 140, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 3))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 86, 59))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[24],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[25],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[24],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[25],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[26],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6497316590856751d, b: 0.2948871063138445d, c: 0.6769448064204325d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8269282096405162d, b: 0.3581353200720486d, c: 0.8171476033366493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4466163270991931d, b: 0.3316219494667978d, c: 0.5050442799976386d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5874631333482591d, b: 0.8853592715922785d, c: 0.4300764093329994d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6824388473951131d, b: 0.5258227306810888d, c: 0.43572464292388635d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9591846577801882d, b: 0.3195985197917276d, c: 0.7308060900538064d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6186137574045629d, b: 0.11531625282032698d, c: 0.13022510206974203d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11437888285113729d, b: 0.019733107530826244d, c: 0.8579833345583695d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6838383987220168d, b: 0.9498885534568391d, c: 0.47376695193404683d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27612107192357416d, b: 0.8987280496030561d, c: 0.39827156382135975d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9435405876611506d, b: 0.43166781195300896d, c: 0.6215874218583965d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4417890459547176d, b: 0.5800838921675441d, c: 0.7807419723694266d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6785075990115416d, b: 0.8870244921078476d, c: 0.45387064206310623d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05594403642149193d, b: 0.9571891809735669d, c: 0.11806022755177747d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5710600819750676d, b: 0.790913336432273d, c: 0.35117038248578847d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5163716311155232d, b: 0.7940293828481338d, c: 0.6664668907815977d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08686975420521892d, b: 0.3253840095913033d, c: 0.972717897525058d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7977843300423099d, b: 0.664557839120943d, c: 0.04548315309821116d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0924294925210365d, b: 0.46557300187573725d, c: 0.20121285398778088d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9075370267553738d, b: 0.8843952581819805d, c: 0.5348673646633328d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43900264846606196d, b: 0.27972998811107597d, c: 0.48387833826260307d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.009627915690501698d, b: 0.33665678800128007d, c: 0.5234577620638159d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18898137920151137d, b: 0.671463673448988d, c: 0.8252073701913588d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07708023788361906d, b: 0.28709973812899103d, c: 0.394333633298548d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.41523319965784833d, b: 0.04757830095315119d, c: 0.7846611149626849d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33737948918104343d, b: 0.21810773512819326d, c: 0.33207937504106144d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2613858466587029d, b: 0.27334832051639535d, c: 0.951537092727191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5142232702381905d, b: 0.33153377256210004d, c: 0.41488560146146913d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08599260453965551d, b: 0.055648725229942575d, c: 0.08856801268025782d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1910799390780923d, b: 0.06026487605427555d, c: 0.280272132110853d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9139424565385824d, b: 0.06407533024233192d, c: 0.2139508349646997d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7839719187733729d, b: 0.45778594267797046d, c: 0.11723588242352834d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8952595985628021d, b: 0.14747348982837372d, c: 0.3099562712891517d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6180763047852632d, b: 0.21439972754846126d, c: 0.44235403131607287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3082610653309331d, b: 0.8455695159570745d, c: 0.5317698696225016d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8774230068240483d, b: 0.3741919987532647d, c: 0.4221433752272086d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7954605862128783d, b: 0.7765389809492408d, c: 0.07573673774896972d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5888750611107734d, b: 0.2655307049446137d, c: 0.45255200335654644d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9630607414464993d, b: 0.9612922488799095d, c: 0.6051746491172895d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25118983536035533d, b: 0.3429841580082901d, c: 0.12282648498465809d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04514120530378152d, b: 0.4762293870391544d, c: 0.5069666994787421d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21358720214877602d, b: 0.9475385486359701d, c: 0.7020648682917692d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7227971373166503d, b: 0.729906627523406d, c: 0.40038869604165994d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.879223596327483d, b: 0.6675336331703176d, c: 0.7073156575123405d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6561004208164708d, b: 0.9281056222810197d, c: 0.7143711186064746d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10221065402668694d, b: 0.6256012195728577d, c: 0.12030312546793875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.92208040990725d, b: 0.6584744192030481d, c: 0.9899616542275815d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6244766573908513d, b: 0.9204318977405614d, c: 0.7251071526790428d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33075726608768974d, b: 0.18549949440875013d, c: 0.5162875901980514d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.652488043209236d, b: 0.9136876100741007d, c: 0.7997850824970894d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5838026507553791d, b: 0.6241796179579496d, c: 0.6845207389048024d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6075046383948023d, b: 0.3232026737129914d, c: 0.4620358831685635d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6047146283692109d, b: 0.7976171196967102d, c: 0.9423376992842344d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4610499351730092d, b: 0.7409875655791842d, c: 0.2928223071232994d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8782816459970301d, b: 0.4689787654100924d, c: 0.21985204664387958d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08070089625586974d, b: 0.02844612679202485d, c: 0.41761676768110123d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.884317611297326d, b: 0.5154312985989019d, c: 0.5225952018926634d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14597865715941838d, b: 0.12283717859249099d, c: 0.2501570069105653d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42112685099870417d, b: 0.20382600141770335d, c: 0.251467685655576d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.016551453387907422d, b: 0.0751750449161821d, c: 0.1652615611889262d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7652285799903122d, b: 0.24371082071585193d, c: 0.3268012910204918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7674608599367725d, b: 0.5786644227713239d, c: 0.9445141932131401d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.452519054189947d, b: 0.21753843642559678d, c: 0.975192478050815d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7670937476819468d, b: 0.4958712041415393d, c: 0.15232505740173952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8602874627112349d, b: 0.720435712676645d, c: 0.8343963725954552d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06236714196332749d, b: 0.09316032725166734d, c: 0.3918910992525374d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7980965918846082d, b: 0.6408487471926584d, c: 0.45243635219334366d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.943650346563328d, b: 0.5694514538318295d, c: 0.5686454629295425d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0929587482039479d, b: 0.180119167512531d, c: 0.5325137419391023d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4583368592509677d, b: 0.1556036142724112d, c: 0.07782825739923749d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5190496554492834d, b: 0.6407148552819351d, c: 0.050999039465874585d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8025409217918507d, b: 0.7580091237198455d, c: 0.29095428512453647d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21800201188389123d, b: 0.06180264593386231d, c: 0.8217668702572657d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9540397731135061d, b: 0.3816952438845078d, c: 0.1763080883989886d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7282241859142399d, b: 0.16669662805900098d, c: 0.4930560182993814d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.453063568235063d, b: 0.061036812975343135d, c: 0.10938312639748216d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7499113686780727d, b: 0.7103781028822166d, c: 0.056035892541290044d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6509624277131104d, b: 0.6079963619865109d, c: 0.9886505232611053d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8450266904976526d, b: 0.12446068014974254d, c: 0.8460973907843296d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8072361615885921d, b: 0.5861414138401947d, c: 0.5356441320725627d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13583542448093333d, b: 0.3850046473346832d, c: 0.9561799815983176d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6497316590856751d, b: 0.2948871063138445d, c: 0.6769448064204325d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8269282096405162d, b: 0.3581353200720486d, c: 0.8171476033366493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4466163270991931d, b: 0.3316219494667978d, c: 0.5050442799976386d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5874631333482591d, b: 0.8853592715922785d, c: 0.4300764093329994d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6824388473951131d, b: 0.5258227306810888d, c: 0.43572464292388635d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9591846577801882d, b: 0.3195985197917276d, c: 0.7308060900538064d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6186137574045629d, b: 0.11531625282032698d, c: 0.13022510206974203d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11437888285113729d, b: 0.019733107530826244d, c: 0.8579833345583695d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6838383987220168d, b: 0.9498885534568391d, c: 0.47376695193404683d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27612107192357416d, b: 0.8987280496030561d, c: 0.39827156382135975d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9435405876611506d, b: 0.43166781195300896d, c: 0.6215874218583965d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4417890459547176d, b: 0.5800838921675441d, c: 0.7807419723694266d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6785075990115416d, b: 0.8870244921078476d, c: 0.45387064206310623d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05594403642149193d, b: 0.9571891809735669d, c: 0.11806022755177747d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5710600819750676d, b: 0.790913336432273d, c: 0.35117038248578847d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5163716311155232d, b: 0.7940293828481338d, c: 0.6664668907815977d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08686975420521892d, b: 0.3253840095913033d, c: 0.972717897525058d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7977843300423099d, b: 0.664557839120943d, c: 0.04548315309821116d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0924294925210365d, b: 0.46557300187573725d, c: 0.20121285398778088d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9075370267553738d, b: 0.8843952581819805d, c: 0.5348673646633328d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43900264846606196d, b: 0.27972998811107597d, c: 0.48387833826260307d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.009627915690501698d, b: 0.33665678800128007d, c: 0.5234577620638159d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18898137920151137d, b: 0.671463673448988d, c: 0.8252073701913588d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07708023788361906d, b: 0.28709973812899103d, c: 0.394333633298548d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.41523319965784833d, b: 0.04757830095315119d, c: 0.7846611149626849d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33737948918104343d, b: 0.21810773512819326d, c: 0.33207937504106144d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2613858466587029d, b: 0.27334832051639535d, c: 0.951537092727191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5142232702381905d, b: 0.33153377256210004d, c: 0.41488560146146913d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08599260453965551d, b: 0.055648725229942575d, c: 0.08856801268025782d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1910799390780923d, b: 0.06026487605427555d, c: 0.280272132110853d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9139424565385824d, b: 0.06407533024233192d, c: 0.2139508349646997d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7839719187733729d, b: 0.45778594267797046d, c: 0.11723588242352834d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8952595985628021d, b: 0.14747348982837372d, c: 0.3099562712891517d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6180763047852632d, b: 0.21439972754846126d, c: 0.44235403131607287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3082610653309331d, b: 0.8455695159570745d, c: 0.5317698696225016d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8774230068240483d, b: 0.3741919987532647d, c: 0.4221433752272086d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7954605862128783d, b: 0.7765389809492408d, c: 0.07573673774896972d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5888750611107734d, b: 0.2655307049446137d, c: 0.45255200335654644d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9630607414464993d, b: 0.9612922488799095d, c: 0.6051746491172895d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25118983536035533d, b: 0.3429841580082901d, c: 0.12282648498465809d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04514120530378152d, b: 0.4762293870391544d, c: 0.5069666994787421d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21358720214877602d, b: 0.9475385486359701d, c: 0.7020648682917692d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7227971373166503d, b: 0.729906627523406d, c: 0.40038869604165994d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.879223596327483d, b: 0.6675336331703176d, c: 0.7073156575123405d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6561004208164708d, b: 0.9281056222810197d, c: 0.7143711186064746d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10221065402668694d, b: 0.6256012195728577d, c: 0.12030312546793875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.92208040990725d, b: 0.6584744192030481d, c: 0.9899616542275815d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6244766573908513d, b: 0.9204318977405614d, c: 0.7251071526790428d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33075726608768974d, b: 0.18549949440875013d, c: 0.5162875901980514d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.652488043209236d, b: 0.9136876100741007d, c: 0.7997850824970894d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5838026507553791d, b: 0.6241796179579496d, c: 0.6845207389048024d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6075046383948023d, b: 0.3232026737129914d, c: 0.4620358831685635d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6047146283692109d, b: 0.7976171196967102d, c: 0.9423376992842344d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4610499351730092d, b: 0.7409875655791842d, c: 0.2928223071232994d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8782816459970301d, b: 0.4689787654100924d, c: 0.21985204664387958d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08070089625586974d, b: 0.02844612679202485d, c: 0.41761676768110123d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.884317611297326d, b: 0.5154312985989019d, c: 0.5225952018926634d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14597865715941838d, b: 0.12283717859249099d, c: 0.2501570069105653d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42112685099870417d, b: 0.20382600141770335d, c: 0.251467685655576d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.016551453387907422d, b: 0.0751750449161821d, c: 0.1652615611889262d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7652285799903122d, b: 0.24371082071585193d, c: 0.3268012910204918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7674608599367725d, b: 0.5786644227713239d, c: 0.9445141932131401d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.452519054189947d, b: 0.21753843642559678d, c: 0.975192478050815d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7670937476819468d, b: 0.4958712041415393d, c: 0.15232505740173952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8602874627112349d, b: 0.720435712676645d, c: 0.8343963725954552d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06236714196332749d, b: 0.09316032725166734d, c: 0.3918910992525374d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7980965918846082d, b: 0.6408487471926584d, c: 0.45243635219334366d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.943650346563328d, b: 0.5694514538318295d, c: 0.5686454629295425d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0929587482039479d, b: 0.180119167512531d, c: 0.5325137419391023d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4583368592509677d, b: 0.1556036142724112d, c: 0.07782825739923749d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5190496554492834d, b: 0.6407148552819351d, c: 0.050999039465874585d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8025409217918507d, b: 0.7580091237198455d, c: 0.29095428512453647d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21800201188389123d, b: 0.06180264593386231d, c: 0.8217668702572657d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9540397731135061d, b: 0.3816952438845078d, c: 0.1763080883989886d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7282241859142399d, b: 0.16669662805900098d, c: 0.4930560182993814d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.453063568235063d, b: 0.061036812975343135d, c: 0.10938312639748216d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7499113686780727d, b: 0.7103781028822166d, c: 0.056035892541290044d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6509624277131104d, b: 0.6079963619865109d, c: 0.9886505232611053d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8450266904976526d, b: 0.12446068014974254d, c: 0.8460973907843296d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8072361615885921d, b: 0.5861414138401947d, c: 0.5356441320725627d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13583542448093333d, b: 0.3850046473346832d, c: 0.9561799815983176d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI), typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlLineSingleTypeline)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

