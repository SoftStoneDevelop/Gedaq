

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

        private readonly NpgsqlLinelineE0M[] _testData = new NpgsqlLinelineE0M[]
        {
            new NpgsqlLinelineE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7240270767424245d, b: 0.928805718076833d, c: 0.4309365704817315d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.531288527141951d, b: 0.9707304308760073d, c: 0.41860161429763576d),
},
            new NpgsqlLinelineE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.654208120324063d, b: 0.7838807978210679d, c: 0.7869347872728142d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.439886107808084d, b: 0.6762372652441483d, c: 0.7900850327188678d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9259794166100933d, b: 0.012556399335831414d, c: 0.4803936282205711d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4540099419309134d, b: 0.754077584100501d, c: 0.9971677682632198d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0955169687853149d, b: 0.2889432081689861d, c: 0.8284557681293159d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0674645434821507d, b: 0.5675394595053278d, c: 0.9869395681763645d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.44516102790903955d, b: 0.11452971464409278d, c: 0.5636716354980637d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8329164293747963d, b: 0.25361407360193144d, c: 0.6850157136342309d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9246249504574767d, b: 0.89140946418928d, c: 0.01854329857616377d),
},
            new NpgsqlLinelineE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2929207431361974d, b: 0.25733957196804347d, c: 0.6798181139267937d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.396704127579094d, b: 0.2961191804464046d, c: 0.8755117272025033d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7799994295073712d, b: 0.10308041126396994d, c: 0.9654126612050004d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6495142590359884d, b: 0.4204604805155281d, c: 0.1713906422500736d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9614494806354096d, b: 0.6097551777335826d, c: 0.79411661743788d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8105290871282868d, b: 0.6626786530831642d, c: 0.30898056903935667d),
},
            new NpgsqlLinelineE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8244370381406901d, b: 0.38514924968325004d, c: 0.686420687922817d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.37514233595755475d, b: 0.5839070815995224d, c: 0.8642189649046158d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.05946122903918416d, b: 0.7240070973556129d, c: 0.7819800183687411d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7128141767488085d, b: 0.1327254686855165d, c: 0.852822445850266d),
},
            new NpgsqlLinelineE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13619445933002117d, b: 0.07425606279321595d, c: 0.6270289433966594d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08357287200797592d, b: 0.055507414546789646d, c: 0.598613118846422d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12455442566558761d, b: 0.8130731505204494d, c: 0.8256524432459124d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.07951270146331668d, b: 0.7099549284143409d, c: 0.3869412543086729d),
},
            new NpgsqlLinelineE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8477739300863091d, b: 0.8015654938794401d, c: 0.691706598620933d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7370112336715771d, b: 0.45289235601413014d, c: 0.9314228481249988d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9220836037793264d, b: 0.6820835595924711d, c: 0.597978002034857d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.02707493444860043d, b: 0.15824434538926946d, c: 0.6654023968419825d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6984881430047156d, b: 0.5053552588025951d, c: 0.5254318435035068d),
},
            new NpgsqlLinelineE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9393460420913113d, b: 0.8304884752288391d, c: 0.5012006833011405d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8101795530109973d, b: 0.746015542585287d, c: 0.23053761877115353d),
},
            new NpgsqlLinelineE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5554020696350541d, b: 0.6107191712148011d, c: 0.6773814049974225d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5774317736906928d, b: 0.48488126643711627d, c: 0.7126698732628831d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7120826238174749d, b: 0.9619015736317151d, c: 0.2924094365291984d),
},
            new NpgsqlLinelineE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9201049828114074d, b: 0.5281593914293926d, c: 0.6711256650601967d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7748232741532483d, b: 0.845973984689249d, c: 0.24841968769716627d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.909822631877327d, b: 0.7667669071535425d, c: 0.1972176341408246d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.568671821745062d, b: 0.4095545077045435d, c: 0.2428841821459118d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9210889329458156d, b: 0.9601274420662421d, c: 0.976718305028844d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7104569737129987d, b: 0.601856390945238d, c: 0.7102881271871153d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3723984470207864d, b: 0.7719589602531485d, c: 0.1219218758187961d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6264184974502799d, b: 0.9800659187725598d, c: 0.28586531755309974d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5509613571874927d, b: 0.9915473069165284d, c: 0.6527506296894011d),
},
            new NpgsqlLinelineE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.744176934254707d, b: 0.10139768571764363d, c: 0.0049653154589685d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.030976385288653763d, b: 0.9343807414250407d, c: 0.6758469345553676d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5113256377373815d, b: 0.6544921659503177d, c: 0.8848899938011539d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7524675226101504d, b: 0.18675069871596028d, c: 0.34370645237521236d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.13026451670736017d, b: 0.47812123468926737d, c: 0.4353353293517064d),
},
            new NpgsqlLinelineE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5703616581382839d, b: 0.28518152042060496d, c: 0.4043974608853993d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9861205311294339d, b: 0.3052044081691113d, c: 0.11852160415884594d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8058489838120637d, b: 0.273279349488166d, c: 0.28554885872588653d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3506270936639857d, b: 0.2845597518254418d, c: 0.2201712300110522d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3784813206860739d, b: 0.2716134719878779d, c: 0.9582339535647063d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.710063493164841d, b: 0.9890254048376231d, c: 0.2351828625152077d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7919219904560783d, b: 0.09726063615336022d, c: 0.8448338975623324d),
},
            new NpgsqlLinelineE0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.045127687519983084d, b: 0.9864099991381486d, c: 0.5300901988644289d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7067737211979197d, b: 0.513618685018516d, c: 0.9530383489064163d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09743956005237997d, b: 0.5326823222791294d, c: 0.7909812222729925d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.42484058831521165d, b: 0.7578384591991122d, c: 0.7017805019845968d),
},
            new NpgsqlLinelineE0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.03086049880199815d, b: 0.7414116863521563d, c: 0.043605125254417065d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.636268137275935d, b: 0.20340199772659084d, c: 0.7021588898771214d),
},
            new NpgsqlLinelineE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.17273020139192974d, b: 0.9350229216750403d, c: 0.3858149408701427d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3878840650661144d, b: 0.3541693513892469d, c: 0.09473862083661522d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7880503050701763d, b: 0.637108217610636d, c: 0.04432374269191397d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1778644045462041d, b: 0.8765217903459136d, c: 0.3874469367058211d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.011974398736327219d, b: 0.27183319573054787d, c: 0.5407984297009836d),
},
            new NpgsqlLinelineE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.00742510129376206d, b: 0.938189097711454d, c: 0.9038086771836179d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5667787904215501d, b: 0.26066482261640234d, c: 0.489700323560606d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3696406699039496d, b: 0.7195783528619388d, c: 0.21412067650283706d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.749941065834962d, b: 0.9066232571891544d, c: 0.1245535986335441d),
},
            new NpgsqlLinelineE0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3565766830438979d, b: 0.8658525217646732d, c: 0.4735716825236389d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.10461361765877641d, b: 0.22441921463535852d, c: 0.04070446461821198d),
},
            new NpgsqlLinelineE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12610765995427886d, b: 0.7539437871343134d, c: 0.2309420562238641d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.690615354156978d, b: 0.47753585997374415d, c: 0.7873441901877828d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8038829862076871d, b: 0.3581937027067781d, c: 0.8369325217259311d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8573032436061321d, b: 0.06892198484883116d, c: 0.4261323226536813d),
},
            new NpgsqlLinelineE0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9545953131922276d, b: 0.7365877221608828d, c: 0.6440817467900373d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0mi(
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
INSERT INTO public.npgsqllinelinee0mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
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
INSERT INTO public.npgsqllinelinee0mi(
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
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
                methodParametrName: "npgsqllinelinee0mi_id", 
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
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9246249504574767d, b: 0.89140946418928d, c: 0.01854329857616377d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8105290871282868d, b: 0.6626786530831642d, c: 0.30898056903935667d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                methodParametrName: "npgsqllinelinee0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7128141767488085d, b: 0.1327254686855165d, c: 0.852822445850266d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07951270146331668d, b: 0.7099549284143409d, c: 0.3869412543086729d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineE0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineE0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllinelinee0mi_id
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
                parametrName: "npgsqllinelinee0mi_id", 
                methodParametrName: "npgsqllinelinee0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 54;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[34], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 102, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 157, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 137, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 152, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[34], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[12], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[13], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[14], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[15], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[16], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[17], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[18], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[19], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[20], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[21], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[22], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[12],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[13],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[14],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[15],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[16],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[17],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[18],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[19],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[20],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[21],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[14], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[15], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[16], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[17], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[18], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[19], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[20], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[21], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[22], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[12],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[13],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[14],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[15],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[16],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[17],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[18],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[19],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7240270767424245d, b: 0.928805718076833d, c: 0.4309365704817315d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.531288527141951d, b: 0.9707304308760073d, c: 0.41860161429763576d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.654208120324063d, b: 0.7838807978210679d, c: 0.7869347872728142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.439886107808084d, b: 0.6762372652441483d, c: 0.7900850327188678d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9259794166100933d, b: 0.012556399335831414d, c: 0.4803936282205711d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4540099419309134d, b: 0.754077584100501d, c: 0.9971677682632198d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0955169687853149d, b: 0.2889432081689861d, c: 0.8284557681293159d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0674645434821507d, b: 0.5675394595053278d, c: 0.9869395681763645d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44516102790903955d, b: 0.11452971464409278d, c: 0.5636716354980637d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8329164293747963d, b: 0.25361407360193144d, c: 0.6850157136342309d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9246249504574767d, b: 0.89140946418928d, c: 0.01854329857616377d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2929207431361974d, b: 0.25733957196804347d, c: 0.6798181139267937d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.396704127579094d, b: 0.2961191804464046d, c: 0.8755117272025033d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7799994295073712d, b: 0.10308041126396994d, c: 0.9654126612050004d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6495142590359884d, b: 0.4204604805155281d, c: 0.1713906422500736d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9614494806354096d, b: 0.6097551777335826d, c: 0.79411661743788d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8105290871282868d, b: 0.6626786530831642d, c: 0.30898056903935667d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8244370381406901d, b: 0.38514924968325004d, c: 0.686420687922817d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37514233595755475d, b: 0.5839070815995224d, c: 0.8642189649046158d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05946122903918416d, b: 0.7240070973556129d, c: 0.7819800183687411d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7128141767488085d, b: 0.1327254686855165d, c: 0.852822445850266d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13619445933002117d, b: 0.07425606279321595d, c: 0.6270289433966594d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08357287200797592d, b: 0.055507414546789646d, c: 0.598613118846422d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12455442566558761d, b: 0.8130731505204494d, c: 0.8256524432459124d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07951270146331668d, b: 0.7099549284143409d, c: 0.3869412543086729d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8477739300863091d, b: 0.8015654938794401d, c: 0.691706598620933d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7370112336715771d, b: 0.45289235601413014d, c: 0.9314228481249988d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9220836037793264d, b: 0.6820835595924711d, c: 0.597978002034857d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02707493444860043d, b: 0.15824434538926946d, c: 0.6654023968419825d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6984881430047156d, b: 0.5053552588025951d, c: 0.5254318435035068d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9393460420913113d, b: 0.8304884752288391d, c: 0.5012006833011405d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8101795530109973d, b: 0.746015542585287d, c: 0.23053761877115353d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5554020696350541d, b: 0.6107191712148011d, c: 0.6773814049974225d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5774317736906928d, b: 0.48488126643711627d, c: 0.7126698732628831d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7120826238174749d, b: 0.9619015736317151d, c: 0.2924094365291984d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9201049828114074d, b: 0.5281593914293926d, c: 0.6711256650601967d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7748232741532483d, b: 0.845973984689249d, c: 0.24841968769716627d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.909822631877327d, b: 0.7667669071535425d, c: 0.1972176341408246d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.568671821745062d, b: 0.4095545077045435d, c: 0.2428841821459118d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9210889329458156d, b: 0.9601274420662421d, c: 0.976718305028844d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7104569737129987d, b: 0.601856390945238d, c: 0.7102881271871153d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3723984470207864d, b: 0.7719589602531485d, c: 0.1219218758187961d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6264184974502799d, b: 0.9800659187725598d, c: 0.28586531755309974d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5509613571874927d, b: 0.9915473069165284d, c: 0.6527506296894011d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.744176934254707d, b: 0.10139768571764363d, c: 0.0049653154589685d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.030976385288653763d, b: 0.9343807414250407d, c: 0.6758469345553676d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5113256377373815d, b: 0.6544921659503177d, c: 0.8848899938011539d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7524675226101504d, b: 0.18675069871596028d, c: 0.34370645237521236d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13026451670736017d, b: 0.47812123468926737d, c: 0.4353353293517064d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5703616581382839d, b: 0.28518152042060496d, c: 0.4043974608853993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9861205311294339d, b: 0.3052044081691113d, c: 0.11852160415884594d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8058489838120637d, b: 0.273279349488166d, c: 0.28554885872588653d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3506270936639857d, b: 0.2845597518254418d, c: 0.2201712300110522d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3784813206860739d, b: 0.2716134719878779d, c: 0.9582339535647063d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.710063493164841d, b: 0.9890254048376231d, c: 0.2351828625152077d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7919219904560783d, b: 0.09726063615336022d, c: 0.8448338975623324d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.045127687519983084d, b: 0.9864099991381486d, c: 0.5300901988644289d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7067737211979197d, b: 0.513618685018516d, c: 0.9530383489064163d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09743956005237997d, b: 0.5326823222791294d, c: 0.7909812222729925d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42484058831521165d, b: 0.7578384591991122d, c: 0.7017805019845968d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03086049880199815d, b: 0.7414116863521563d, c: 0.043605125254417065d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.636268137275935d, b: 0.20340199772659084d, c: 0.7021588898771214d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17273020139192974d, b: 0.9350229216750403d, c: 0.3858149408701427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3878840650661144d, b: 0.3541693513892469d, c: 0.09473862083661522d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7880503050701763d, b: 0.637108217610636d, c: 0.04432374269191397d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1778644045462041d, b: 0.8765217903459136d, c: 0.3874469367058211d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.011974398736327219d, b: 0.27183319573054787d, c: 0.5407984297009836d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00742510129376206d, b: 0.938189097711454d, c: 0.9038086771836179d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5667787904215501d, b: 0.26066482261640234d, c: 0.489700323560606d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3696406699039496d, b: 0.7195783528619388d, c: 0.21412067650283706d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.749941065834962d, b: 0.9066232571891544d, c: 0.1245535986335441d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3565766830438979d, b: 0.8658525217646732d, c: 0.4735716825236389d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10461361765877641d, b: 0.22441921463535852d, c: 0.04070446461821198d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12610765995427886d, b: 0.7539437871343134d, c: 0.2309420562238641d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.690615354156978d, b: 0.47753585997374415d, c: 0.7873441901877828d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8038829862076871d, b: 0.3581937027067781d, c: 0.8369325217259311d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8573032436061321d, b: 0.06892198484883116d, c: 0.4261323226536813d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9545953131922276d, b: 0.7365877221608828d, c: 0.6440817467900373d))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7240270767424245d, b: 0.928805718076833d, c: 0.4309365704817315d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.531288527141951d, b: 0.9707304308760073d, c: 0.41860161429763576d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.654208120324063d, b: 0.7838807978210679d, c: 0.7869347872728142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.439886107808084d, b: 0.6762372652441483d, c: 0.7900850327188678d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9259794166100933d, b: 0.012556399335831414d, c: 0.4803936282205711d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4540099419309134d, b: 0.754077584100501d, c: 0.9971677682632198d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0955169687853149d, b: 0.2889432081689861d, c: 0.8284557681293159d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0674645434821507d, b: 0.5675394595053278d, c: 0.9869395681763645d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44516102790903955d, b: 0.11452971464409278d, c: 0.5636716354980637d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8329164293747963d, b: 0.25361407360193144d, c: 0.6850157136342309d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9246249504574767d, b: 0.89140946418928d, c: 0.01854329857616377d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2929207431361974d, b: 0.25733957196804347d, c: 0.6798181139267937d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.396704127579094d, b: 0.2961191804464046d, c: 0.8755117272025033d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7799994295073712d, b: 0.10308041126396994d, c: 0.9654126612050004d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6495142590359884d, b: 0.4204604805155281d, c: 0.1713906422500736d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9614494806354096d, b: 0.6097551777335826d, c: 0.79411661743788d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8105290871282868d, b: 0.6626786530831642d, c: 0.30898056903935667d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8244370381406901d, b: 0.38514924968325004d, c: 0.686420687922817d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37514233595755475d, b: 0.5839070815995224d, c: 0.8642189649046158d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05946122903918416d, b: 0.7240070973556129d, c: 0.7819800183687411d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7128141767488085d, b: 0.1327254686855165d, c: 0.852822445850266d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13619445933002117d, b: 0.07425606279321595d, c: 0.6270289433966594d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08357287200797592d, b: 0.055507414546789646d, c: 0.598613118846422d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12455442566558761d, b: 0.8130731505204494d, c: 0.8256524432459124d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07951270146331668d, b: 0.7099549284143409d, c: 0.3869412543086729d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8477739300863091d, b: 0.8015654938794401d, c: 0.691706598620933d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7370112336715771d, b: 0.45289235601413014d, c: 0.9314228481249988d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9220836037793264d, b: 0.6820835595924711d, c: 0.597978002034857d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02707493444860043d, b: 0.15824434538926946d, c: 0.6654023968419825d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6984881430047156d, b: 0.5053552588025951d, c: 0.5254318435035068d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9393460420913113d, b: 0.8304884752288391d, c: 0.5012006833011405d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8101795530109973d, b: 0.746015542585287d, c: 0.23053761877115353d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5554020696350541d, b: 0.6107191712148011d, c: 0.6773814049974225d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5774317736906928d, b: 0.48488126643711627d, c: 0.7126698732628831d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7120826238174749d, b: 0.9619015736317151d, c: 0.2924094365291984d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9201049828114074d, b: 0.5281593914293926d, c: 0.6711256650601967d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7748232741532483d, b: 0.845973984689249d, c: 0.24841968769716627d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.909822631877327d, b: 0.7667669071535425d, c: 0.1972176341408246d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.568671821745062d, b: 0.4095545077045435d, c: 0.2428841821459118d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9210889329458156d, b: 0.9601274420662421d, c: 0.976718305028844d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7104569737129987d, b: 0.601856390945238d, c: 0.7102881271871153d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3723984470207864d, b: 0.7719589602531485d, c: 0.1219218758187961d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6264184974502799d, b: 0.9800659187725598d, c: 0.28586531755309974d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5509613571874927d, b: 0.9915473069165284d, c: 0.6527506296894011d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.744176934254707d, b: 0.10139768571764363d, c: 0.0049653154589685d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.030976385288653763d, b: 0.9343807414250407d, c: 0.6758469345553676d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5113256377373815d, b: 0.6544921659503177d, c: 0.8848899938011539d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7524675226101504d, b: 0.18675069871596028d, c: 0.34370645237521236d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13026451670736017d, b: 0.47812123468926737d, c: 0.4353353293517064d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5703616581382839d, b: 0.28518152042060496d, c: 0.4043974608853993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9861205311294339d, b: 0.3052044081691113d, c: 0.11852160415884594d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8058489838120637d, b: 0.273279349488166d, c: 0.28554885872588653d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3506270936639857d, b: 0.2845597518254418d, c: 0.2201712300110522d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3784813206860739d, b: 0.2716134719878779d, c: 0.9582339535647063d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.710063493164841d, b: 0.9890254048376231d, c: 0.2351828625152077d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7919219904560783d, b: 0.09726063615336022d, c: 0.8448338975623324d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.045127687519983084d, b: 0.9864099991381486d, c: 0.5300901988644289d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7067737211979197d, b: 0.513618685018516d, c: 0.9530383489064163d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09743956005237997d, b: 0.5326823222791294d, c: 0.7909812222729925d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42484058831521165d, b: 0.7578384591991122d, c: 0.7017805019845968d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03086049880199815d, b: 0.7414116863521563d, c: 0.043605125254417065d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.636268137275935d, b: 0.20340199772659084d, c: 0.7021588898771214d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17273020139192974d, b: 0.9350229216750403d, c: 0.3858149408701427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3878840650661144d, b: 0.3541693513892469d, c: 0.09473862083661522d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7880503050701763d, b: 0.637108217610636d, c: 0.04432374269191397d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1778644045462041d, b: 0.8765217903459136d, c: 0.3874469367058211d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.011974398736327219d, b: 0.27183319573054787d, c: 0.5407984297009836d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00742510129376206d, b: 0.938189097711454d, c: 0.9038086771836179d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5667787904215501d, b: 0.26066482261640234d, c: 0.489700323560606d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3696406699039496d, b: 0.7195783528619388d, c: 0.21412067650283706d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.749941065834962d, b: 0.9066232571891544d, c: 0.1245535986335441d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3565766830438979d, b: 0.8658525217646732d, c: 0.4735716825236389d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10461361765877641d, b: 0.22441921463535852d, c: 0.04070446461821198d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12610765995427886d, b: 0.7539437871343134d, c: 0.2309420562238641d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.690615354156978d, b: 0.47753585997374415d, c: 0.7873441901877828d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8038829862076871d, b: 0.3581937027067781d, c: 0.8369325217259311d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8573032436061321d, b: 0.06892198484883116d, c: 0.4261323226536813d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9545953131922276d, b: 0.7365877221608828d, c: 0.6440817467900373d))));//Value

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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
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
COPY public.binary_npgsqllinelinee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MI),
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
                var importCollection = new List<NpgsqlLinelineE0MI>(2);
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
                    NpgsqlLinelineE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MI>(2);
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
                    NpgsqlLinelineE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineE0M),
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
FROM public.binary_npgsqllinelinee0m m
LEFT JOIN public.binary_npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                var importCollection = new List<NpgsqlLinelineE0M>();
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
                    NpgsqlLinelineE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0M>();
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
                    NpgsqlLinelineE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlLinelineE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI), typeof(NpgsqlLinelineE0MI)],
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
                var models1 = new List<NpgsqlLinelineE0MI>();
                var models2 = new List<NpgsqlLinelineE0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MI>();
                var models2 = new List<NpgsqlLinelineE0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
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
                    NpgsqlLinelineE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlLinelineE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

