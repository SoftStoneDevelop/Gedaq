

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
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4694992027497411d, b: 0.23487814362654857d, c: 0.32785128481596726d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9373882746573919d, b: 0.8682099084127313d, c: 0.04529895455751631d),
},
            new NpgsqlLineline0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3615470914561524d, b: 0.36322587800581774d, c: 0.3654119388401076d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5190302033491522d, b: 0.802002966834019d, c: 0.16136925095518007d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9144773485461102d, b: 0.3621597834674042d, c: 0.5775922970539493d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7653373630217238d, b: 0.732544751588666d, c: 0.7892560853222481d),
},
            new NpgsqlLineline0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5926946323298227d, b: 0.5586380588136362d, c: 0.7689904994570558d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20305616789108882d, b: 0.16973584463618596d, c: 0.481218160332316d),
},
            new NpgsqlLineline0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.46944466684071173d, b: 0.5995520810184035d, c: 0.17840969816818508d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.33460060760374655d, b: 0.5232644455563814d, c: 0.028518630598721173d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5229921422324332d, b: 0.8919859884899404d, c: 0.45561380186928235d),
},
            new NpgsqlLineline0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24510830021752483d, b: 0.8110866277512602d, c: 0.03595427480256419d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6235528389102546d, b: 0.9814440146745091d, c: 0.42946155389926877d),
},
            new NpgsqlLineline0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.25739803839921815d, b: 0.8637587466220817d, c: 0.14967484077061755d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.49415796398718304d, b: 0.8380498333929018d, c: 0.8749421739551065d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4043120891680586d, b: 0.6101941131833251d, c: 0.5032722036141674d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4119121343405233d, b: 0.509051425655352d, c: 0.4915987414997822d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5726509039155624d, b: 0.500613644117296d, c: 0.6975510249733715d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7222367611480959d, b: 0.8890630774074164d, c: 0.9613614777733238d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8654960923826728d, b: 0.4510868731882607d, c: 0.0513586281166607d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2404918416048537d, b: 0.579625426789194d, c: 0.8384962143152203d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9933715761030627d, b: 0.567331114805388d, c: 0.012095281709525008d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.469965555946402d, b: 0.6885095099785932d, c: 0.6337108839938048d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3002600602077278d, b: 0.8371710253863033d, c: 0.26396062638836715d),
},
            new NpgsqlLineline0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3355658433601626d, b: 0.05821823899272904d, c: 0.6255313989459593d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2046986876051764d, b: 0.5652175839403589d, c: 0.06762864850861705d),
},
            new NpgsqlLineline0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6527760624529237d, b: 0.592791419428675d, c: 0.1680493484109794d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2816235069344307d, b: 0.6595601965501885d, c: 0.09992616445901703d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2838067762202612d, b: 0.9553708336137712d, c: 0.6095773002349227d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.15046742816980208d, b: 0.594849709323948d, c: 0.9006343557714731d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.02099110796804826d, b: 0.1688278471945388d, c: 0.1454846936842049d),
},
            new NpgsqlLineline0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5091619475439579d, b: 0.023213792275647238d, c: 0.841937200499422d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5359681618482468d, b: 0.906635211830372d, c: 0.20893560622668617d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08331904284918867d, b: 0.9475592123416494d, c: 0.13569981102783935d),
},
            new NpgsqlLineline0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.644349038930444d, b: 0.03132059769247353d, c: 0.26124745916396896d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9917024472985031d, b: 0.8720093861911759d, c: 0.07168631555790395d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.03136649532138369d, b: 0.07802352638013066d, c: 0.5609596061941498d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7142244019165187d, b: 0.5566318475826193d, c: 0.878207159561681d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2776814137048068d, b: 0.07525147374565044d, c: 0.6504454552164072d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08385028717873799d, b: 0.29957605444981017d, c: 0.6733442584963341d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13532952654351005d, b: 0.940483645155948d, c: 0.9899194945958706d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.13002335641584306d, b: 0.46879718108275825d, c: 0.605137395783363d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.40877591765168864d, b: 0.6719312180027219d, c: 0.4206834963212823d),
},
            new NpgsqlLineline0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8704814587940528d, b: 0.11591057678591776d, c: 0.8229116100829755d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9953148972923473d, b: 0.8808421859377668d, c: 0.09463831808862255d),
},
            new NpgsqlLineline0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3251384503083238d, b: 0.018544328151615663d, c: 0.5805531948925501d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2439272556265042d, b: 0.3175897627715879d, c: 0.8474608004544895d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.730878050656322d, b: 0.3743763044754216d, c: 0.9670086021312502d),
},
            new NpgsqlLineline0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5741923229481783d, b: 0.47896042791511306d, c: 0.7646231854740027d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7416167692839657d, b: 0.03872127660601832d, c: 0.09679326361580176d),
},
            new NpgsqlLineline0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.32312289478386436d, b: 0.6227010188375358d, c: 0.934609907467914d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5844312798151498d, b: 0.08185153130830913d, c: 0.6209806951613572d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5538464380992262d, b: 0.7301443200636755d, c: 0.21378817223617608d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5976494734284187d, b: 0.5265421853459018d, c: 0.27047522970551097d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.36339065421075445d, b: 0.5453247584751969d, c: 0.3691594067781083d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1029990832932518d, b: 0.7292087925462338d, c: 0.96657902106405d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4209392671713469d, b: 0.6970932587331756d, c: 0.9622793956878929d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5464331842581315d, b: 0.4665347558386117d, c: 0.5636599238037663d),
},
            new NpgsqlLineline0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12030991601808005d, b: 0.02838755361510259d, c: 0.40168633948185406d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5958539533139691d, b: 0.6370144439250117d, c: 0.06118983551077406d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23172595463043233d, b: 0.6472686077126676d, c: 0.6453413095943892d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6704139164762911d, b: 0.06876553808310593d, c: 0.23944308695881922d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9688646371780402d, b: 0.17063776733793778d, c: 0.7816867918262564d),
},
            new NpgsqlLineline0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8852379399403075d, b: 0.41649134688111633d, c: 0.6635350161949735d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7909587150672642d, b: 0.8220725156547283d, c: 0.10750281798198214d),
},
            new NpgsqlLineline0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6621902380404988d, b: 0.49929838483123834d, c: 0.48985938873012524d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.17362037221910132d, b: 0.7983892531524023d, c: 0.5795128927830521d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.03790058494647652d, b: 0.1399164728539951d, c: 0.4364073650649736d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.47375965298344647d, b: 0.5091993918452584d, c: 0.3227226206329967d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.11095443677858674d, b: 0.1902155167234867d, c: 0.18572494662348304d),
},
            new NpgsqlLineline0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5330293132685875d, b: 0.5735434113019943d, c: 0.7190304729936905d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.883343418701575d, b: 0.8794846025040636d, c: 0.20624514994039755d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3371926543718351d, b: 0.5477337489213584d, c: 0.16962000890954654d),
},
            new NpgsqlLineline0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2307742366507458d, b: 0.9934579379495513d, c: 0.6617907610120028d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7905275041002142d, b: 0.030291276229067687d, c: 0.32515632147129825d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9719571312817068d, b: 0.36848005935448924d, c: 0.6164547079228669d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8201659838976264d, b: 0.3477773312845779d, c: 0.9858877780018213d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.28307533465298973d, b: 0.3665498431619528d, c: 0.5215627408204724d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8709888021058525d, b: 0.20209236289714338d, c: 0.12390940971568432d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.48398870540198224d, b: 0.397351677520979d, c: 0.4790726852270928d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3850832067377885d, b: 0.2649153186381762d, c: 0.5545265752903163d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8396060870095052d, b: 0.9247940465646248d, c: 0.7295432623606958d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6235528389102546d, b: 0.9814440146745091d, c: 0.42946155389926877d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3002600602077278d, b: 0.8371710253863033d, c: 0.26396062638836715d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2046986876051764d, b: 0.5652175839403589d, c: 0.06762864850861705d)));
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 20;
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 25, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 51, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 10, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 117, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 34, 38))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4694992027497411d, b: 0.23487814362654857d, c: 0.32785128481596726d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9373882746573919d, b: 0.8682099084127313d, c: 0.04529895455751631d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3615470914561524d, b: 0.36322587800581774d, c: 0.3654119388401076d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5190302033491522d, b: 0.802002966834019d, c: 0.16136925095518007d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9144773485461102d, b: 0.3621597834674042d, c: 0.5775922970539493d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7653373630217238d, b: 0.732544751588666d, c: 0.7892560853222481d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5926946323298227d, b: 0.5586380588136362d, c: 0.7689904994570558d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20305616789108882d, b: 0.16973584463618596d, c: 0.481218160332316d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46944466684071173d, b: 0.5995520810184035d, c: 0.17840969816818508d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33460060760374655d, b: 0.5232644455563814d, c: 0.028518630598721173d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5229921422324332d, b: 0.8919859884899404d, c: 0.45561380186928235d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24510830021752483d, b: 0.8110866277512602d, c: 0.03595427480256419d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6235528389102546d, b: 0.9814440146745091d, c: 0.42946155389926877d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25739803839921815d, b: 0.8637587466220817d, c: 0.14967484077061755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49415796398718304d, b: 0.8380498333929018d, c: 0.8749421739551065d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4043120891680586d, b: 0.6101941131833251d, c: 0.5032722036141674d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4119121343405233d, b: 0.509051425655352d, c: 0.4915987414997822d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5726509039155624d, b: 0.500613644117296d, c: 0.6975510249733715d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7222367611480959d, b: 0.8890630774074164d, c: 0.9613614777733238d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8654960923826728d, b: 0.4510868731882607d, c: 0.0513586281166607d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2404918416048537d, b: 0.579625426789194d, c: 0.8384962143152203d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9933715761030627d, b: 0.567331114805388d, c: 0.012095281709525008d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.469965555946402d, b: 0.6885095099785932d, c: 0.6337108839938048d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3002600602077278d, b: 0.8371710253863033d, c: 0.26396062638836715d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3355658433601626d, b: 0.05821823899272904d, c: 0.6255313989459593d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2046986876051764d, b: 0.5652175839403589d, c: 0.06762864850861705d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6527760624529237d, b: 0.592791419428675d, c: 0.1680493484109794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2816235069344307d, b: 0.6595601965501885d, c: 0.09992616445901703d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2838067762202612d, b: 0.9553708336137712d, c: 0.6095773002349227d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15046742816980208d, b: 0.594849709323948d, c: 0.9006343557714731d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02099110796804826d, b: 0.1688278471945388d, c: 0.1454846936842049d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5091619475439579d, b: 0.023213792275647238d, c: 0.841937200499422d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5359681618482468d, b: 0.906635211830372d, c: 0.20893560622668617d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08331904284918867d, b: 0.9475592123416494d, c: 0.13569981102783935d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.644349038930444d, b: 0.03132059769247353d, c: 0.26124745916396896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9917024472985031d, b: 0.8720093861911759d, c: 0.07168631555790395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03136649532138369d, b: 0.07802352638013066d, c: 0.5609596061941498d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7142244019165187d, b: 0.5566318475826193d, c: 0.878207159561681d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2776814137048068d, b: 0.07525147374565044d, c: 0.6504454552164072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08385028717873799d, b: 0.29957605444981017d, c: 0.6733442584963341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13532952654351005d, b: 0.940483645155948d, c: 0.9899194945958706d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13002335641584306d, b: 0.46879718108275825d, c: 0.605137395783363d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40877591765168864d, b: 0.6719312180027219d, c: 0.4206834963212823d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8704814587940528d, b: 0.11591057678591776d, c: 0.8229116100829755d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9953148972923473d, b: 0.8808421859377668d, c: 0.09463831808862255d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3251384503083238d, b: 0.018544328151615663d, c: 0.5805531948925501d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2439272556265042d, b: 0.3175897627715879d, c: 0.8474608004544895d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.730878050656322d, b: 0.3743763044754216d, c: 0.9670086021312502d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5741923229481783d, b: 0.47896042791511306d, c: 0.7646231854740027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7416167692839657d, b: 0.03872127660601832d, c: 0.09679326361580176d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32312289478386436d, b: 0.6227010188375358d, c: 0.934609907467914d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5844312798151498d, b: 0.08185153130830913d, c: 0.6209806951613572d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5538464380992262d, b: 0.7301443200636755d, c: 0.21378817223617608d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5976494734284187d, b: 0.5265421853459018d, c: 0.27047522970551097d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36339065421075445d, b: 0.5453247584751969d, c: 0.3691594067781083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1029990832932518d, b: 0.7292087925462338d, c: 0.96657902106405d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4209392671713469d, b: 0.6970932587331756d, c: 0.9622793956878929d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5464331842581315d, b: 0.4665347558386117d, c: 0.5636599238037663d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12030991601808005d, b: 0.02838755361510259d, c: 0.40168633948185406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5958539533139691d, b: 0.6370144439250117d, c: 0.06118983551077406d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23172595463043233d, b: 0.6472686077126676d, c: 0.6453413095943892d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6704139164762911d, b: 0.06876553808310593d, c: 0.23944308695881922d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9688646371780402d, b: 0.17063776733793778d, c: 0.7816867918262564d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8852379399403075d, b: 0.41649134688111633d, c: 0.6635350161949735d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7909587150672642d, b: 0.8220725156547283d, c: 0.10750281798198214d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6621902380404988d, b: 0.49929838483123834d, c: 0.48985938873012524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17362037221910132d, b: 0.7983892531524023d, c: 0.5795128927830521d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03790058494647652d, b: 0.1399164728539951d, c: 0.4364073650649736d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47375965298344647d, b: 0.5091993918452584d, c: 0.3227226206329967d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11095443677858674d, b: 0.1902155167234867d, c: 0.18572494662348304d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5330293132685875d, b: 0.5735434113019943d, c: 0.7190304729936905d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.883343418701575d, b: 0.8794846025040636d, c: 0.20624514994039755d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3371926543718351d, b: 0.5477337489213584d, c: 0.16962000890954654d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2307742366507458d, b: 0.9934579379495513d, c: 0.6617907610120028d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7905275041002142d, b: 0.030291276229067687d, c: 0.32515632147129825d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9719571312817068d, b: 0.36848005935448924d, c: 0.6164547079228669d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8201659838976264d, b: 0.3477773312845779d, c: 0.9858877780018213d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28307533465298973d, b: 0.3665498431619528d, c: 0.5215627408204724d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8709888021058525d, b: 0.20209236289714338d, c: 0.12390940971568432d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48398870540198224d, b: 0.397351677520979d, c: 0.4790726852270928d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3850832067377885d, b: 0.2649153186381762d, c: 0.5545265752903163d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8396060870095052d, b: 0.9247940465646248d, c: 0.7295432623606958d))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4694992027497411d, b: 0.23487814362654857d, c: 0.32785128481596726d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9373882746573919d, b: 0.8682099084127313d, c: 0.04529895455751631d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3615470914561524d, b: 0.36322587800581774d, c: 0.3654119388401076d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5190302033491522d, b: 0.802002966834019d, c: 0.16136925095518007d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9144773485461102d, b: 0.3621597834674042d, c: 0.5775922970539493d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7653373630217238d, b: 0.732544751588666d, c: 0.7892560853222481d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5926946323298227d, b: 0.5586380588136362d, c: 0.7689904994570558d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20305616789108882d, b: 0.16973584463618596d, c: 0.481218160332316d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46944466684071173d, b: 0.5995520810184035d, c: 0.17840969816818508d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33460060760374655d, b: 0.5232644455563814d, c: 0.028518630598721173d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5229921422324332d, b: 0.8919859884899404d, c: 0.45561380186928235d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24510830021752483d, b: 0.8110866277512602d, c: 0.03595427480256419d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6235528389102546d, b: 0.9814440146745091d, c: 0.42946155389926877d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25739803839921815d, b: 0.8637587466220817d, c: 0.14967484077061755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49415796398718304d, b: 0.8380498333929018d, c: 0.8749421739551065d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4043120891680586d, b: 0.6101941131833251d, c: 0.5032722036141674d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4119121343405233d, b: 0.509051425655352d, c: 0.4915987414997822d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5726509039155624d, b: 0.500613644117296d, c: 0.6975510249733715d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7222367611480959d, b: 0.8890630774074164d, c: 0.9613614777733238d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8654960923826728d, b: 0.4510868731882607d, c: 0.0513586281166607d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2404918416048537d, b: 0.579625426789194d, c: 0.8384962143152203d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9933715761030627d, b: 0.567331114805388d, c: 0.012095281709525008d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.469965555946402d, b: 0.6885095099785932d, c: 0.6337108839938048d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3002600602077278d, b: 0.8371710253863033d, c: 0.26396062638836715d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3355658433601626d, b: 0.05821823899272904d, c: 0.6255313989459593d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2046986876051764d, b: 0.5652175839403589d, c: 0.06762864850861705d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6527760624529237d, b: 0.592791419428675d, c: 0.1680493484109794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2816235069344307d, b: 0.6595601965501885d, c: 0.09992616445901703d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2838067762202612d, b: 0.9553708336137712d, c: 0.6095773002349227d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15046742816980208d, b: 0.594849709323948d, c: 0.9006343557714731d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02099110796804826d, b: 0.1688278471945388d, c: 0.1454846936842049d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5091619475439579d, b: 0.023213792275647238d, c: 0.841937200499422d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5359681618482468d, b: 0.906635211830372d, c: 0.20893560622668617d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08331904284918867d, b: 0.9475592123416494d, c: 0.13569981102783935d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.644349038930444d, b: 0.03132059769247353d, c: 0.26124745916396896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9917024472985031d, b: 0.8720093861911759d, c: 0.07168631555790395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03136649532138369d, b: 0.07802352638013066d, c: 0.5609596061941498d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7142244019165187d, b: 0.5566318475826193d, c: 0.878207159561681d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2776814137048068d, b: 0.07525147374565044d, c: 0.6504454552164072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08385028717873799d, b: 0.29957605444981017d, c: 0.6733442584963341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13532952654351005d, b: 0.940483645155948d, c: 0.9899194945958706d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13002335641584306d, b: 0.46879718108275825d, c: 0.605137395783363d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40877591765168864d, b: 0.6719312180027219d, c: 0.4206834963212823d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8704814587940528d, b: 0.11591057678591776d, c: 0.8229116100829755d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9953148972923473d, b: 0.8808421859377668d, c: 0.09463831808862255d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3251384503083238d, b: 0.018544328151615663d, c: 0.5805531948925501d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2439272556265042d, b: 0.3175897627715879d, c: 0.8474608004544895d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.730878050656322d, b: 0.3743763044754216d, c: 0.9670086021312502d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5741923229481783d, b: 0.47896042791511306d, c: 0.7646231854740027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7416167692839657d, b: 0.03872127660601832d, c: 0.09679326361580176d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32312289478386436d, b: 0.6227010188375358d, c: 0.934609907467914d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5844312798151498d, b: 0.08185153130830913d, c: 0.6209806951613572d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5538464380992262d, b: 0.7301443200636755d, c: 0.21378817223617608d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5976494734284187d, b: 0.5265421853459018d, c: 0.27047522970551097d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36339065421075445d, b: 0.5453247584751969d, c: 0.3691594067781083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1029990832932518d, b: 0.7292087925462338d, c: 0.96657902106405d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4209392671713469d, b: 0.6970932587331756d, c: 0.9622793956878929d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5464331842581315d, b: 0.4665347558386117d, c: 0.5636599238037663d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12030991601808005d, b: 0.02838755361510259d, c: 0.40168633948185406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5958539533139691d, b: 0.6370144439250117d, c: 0.06118983551077406d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23172595463043233d, b: 0.6472686077126676d, c: 0.6453413095943892d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6704139164762911d, b: 0.06876553808310593d, c: 0.23944308695881922d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9688646371780402d, b: 0.17063776733793778d, c: 0.7816867918262564d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8852379399403075d, b: 0.41649134688111633d, c: 0.6635350161949735d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7909587150672642d, b: 0.8220725156547283d, c: 0.10750281798198214d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6621902380404988d, b: 0.49929838483123834d, c: 0.48985938873012524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17362037221910132d, b: 0.7983892531524023d, c: 0.5795128927830521d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03790058494647652d, b: 0.1399164728539951d, c: 0.4364073650649736d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47375965298344647d, b: 0.5091993918452584d, c: 0.3227226206329967d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11095443677858674d, b: 0.1902155167234867d, c: 0.18572494662348304d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5330293132685875d, b: 0.5735434113019943d, c: 0.7190304729936905d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.883343418701575d, b: 0.8794846025040636d, c: 0.20624514994039755d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3371926543718351d, b: 0.5477337489213584d, c: 0.16962000890954654d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2307742366507458d, b: 0.9934579379495513d, c: 0.6617907610120028d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7905275041002142d, b: 0.030291276229067687d, c: 0.32515632147129825d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9719571312817068d, b: 0.36848005935448924d, c: 0.6164547079228669d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8201659838976264d, b: 0.3477773312845779d, c: 0.9858877780018213d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28307533465298973d, b: 0.3665498431619528d, c: 0.5215627408204724d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8709888021058525d, b: 0.20209236289714338d, c: 0.12390940971568432d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48398870540198224d, b: 0.397351677520979d, c: 0.4790726852270928d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3850832067377885d, b: 0.2649153186381762d, c: 0.5545265752903163d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8396060870095052d, b: 0.9247940465646248d, c: 0.7295432623606958d))));//Value

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

