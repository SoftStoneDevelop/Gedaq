

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
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9709452018966708d, b: 0.4660201073202823d, c: 0.18686965292862945d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1219279280950949d, b: 0.3152025376883978d, c: 0.805261528935731d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4341134590912409d, b: 0.3295865512920264d, c: 0.033002322024837216d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.645418687268759d, b: 0.07150024763206253d, c: 0.20316403636133606d),
},
            new NpgsqlLinelineE0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3572553115182976d, b: 0.3582914823557991d, c: 0.912063071325988d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8062254058955929d, b: 0.0053443485456626805d, c: 0.9737037356753694d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.25696784394257255d, b: 0.38598180644051183d, c: 0.8222904991719625d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.250142194314951d, b: 0.3595028081145548d, c: 0.39161672293930794d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8311372849722507d, b: 0.08596997190393307d, c: 0.16625455063837968d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0719468118539126d, b: 0.22433992952614257d, c: 0.3301753003852421d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3723412672435201d, b: 0.7159827237627175d, c: 0.8935646369416627d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1564704093827699d, b: 0.38686433648717367d, c: 0.08214911989117912d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18063017746693588d, b: 0.26923178996114727d, c: 0.13393883995463174d),
},
            new NpgsqlLinelineE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8729411251941156d, b: 0.9510071671079122d, c: 0.7805403012344102d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20601361181440148d, b: 0.5117643752031941d, c: 0.15912132928365375d),
},
            new NpgsqlLinelineE0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9812446986724748d, b: 0.3215066977527944d, c: 0.15244302231922802d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2997590263816964d, b: 0.1344901506943813d, c: 0.3803536921122196d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.907557337383021d, b: 0.6912403790872849d, c: 0.35398158881418973d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7533704518637518d, b: 0.5440399029565929d, c: 0.35670240476696347d),
},
            new NpgsqlLinelineE0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1286595352815959d, b: 0.5158932045556773d, c: 0.39637871705452643d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3740486864402788d, b: 0.5472865228259144d, c: 0.9085096461923835d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2533423817688929d, b: 0.2709880167322084d, c: 0.9749009206400604d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8805031386747483d, b: 0.0687869353662316d, c: 0.8983521087372126d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.48474668197742776d, b: 0.5554236843294613d, c: 0.3480580430629103d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7710121429106387d, b: 0.619710193406977d, c: 0.27069415131327346d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.24720485070733256d, b: 0.9610119751670816d, c: 0.9285194728710102d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.36395438012141956d, b: 0.48868230477373886d, c: 0.2859641263183609d),
},
            new NpgsqlLinelineE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12116633761402018d, b: 0.9939040432183426d, c: 0.36608022987343025d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.47119801095592373d, b: 0.18003828641434028d, c: 0.36615231832297035d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.43377538856179043d, b: 0.35095232026317713d, c: 0.7602685164067796d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9077017295081913d, b: 0.5895746558260463d, c: 0.4703117033864701d),
},
            new NpgsqlLinelineE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4790084747659613d, b: 0.7623666746109795d, c: 0.36179692937186014d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8379337251361676d, b: 0.2612788067352433d, c: 0.014059516156209928d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.745143456102653d, b: 0.26207887443142464d, c: 0.801112653054045d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.28256226415818475d, b: 0.4471725090985006d, c: 0.19308082547388639d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20006951141309537d, b: 0.5138045820101859d, c: 0.5034420748943851d),
},
            new NpgsqlLinelineE0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8688460959362015d, b: 0.4147207778530375d, c: 0.99264937019968d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6237469173245658d, b: 0.950557859823525d, c: 0.6945441540385685d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.97121011523395d, b: 0.823453842614714d, c: 0.3532198093281832d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9374981972680579d, b: 0.17476878524974393d, c: 0.4525272330179825d),
},
            new NpgsqlLinelineE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.760894685247588d, b: 0.3707516448923187d, c: 0.8368065274087406d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2877694097083142d, b: 0.19078302830352478d, c: 0.8179130959911173d),
},
            new NpgsqlLinelineE0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45750978906782014d, b: 0.6288252512678947d, c: 0.32381979173392017d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5747151354523861d, b: 0.10352802213419632d, c: 0.8512271405758918d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7569294980801573d, b: 0.622875472993711d, c: 0.9253755709722811d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6983792312821371d, b: 0.4240569869446634d, c: 0.01629163119939081d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7579549399165759d, b: 0.7186550725601889d, c: 0.031751089428012524d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6144560730388233d, b: 0.7292398790519707d, c: 0.6020332098607232d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.29666716085075884d, b: 0.09001381056875768d, c: 0.1273937474653407d),
},
            new NpgsqlLinelineE0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23790636159480705d, b: 0.44191129812327656d, c: 0.9408279448430993d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6170950801122617d, b: 0.7881568691654269d, c: 0.5235882865466225d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.539299666913143d, b: 0.9815131847294666d, c: 0.9078035418495987d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5463102743589092d, b: 0.11449185640307791d, c: 0.9449097215802827d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6751028267596737d, b: 0.6874504827407537d, c: 0.5366293449590848d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5649973233121753d, b: 0.937946506714981d, c: 0.6817640209871212d),
},
            new NpgsqlLinelineE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5916350641947687d, b: 0.12604662543942613d, c: 0.8123961950395521d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2912984489940794d, b: 0.3203822193448812d, c: 0.879578344902394d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.039596455050626145d, b: 0.9993717248161099d, c: 0.7128394680077289d),
},
            new NpgsqlLinelineE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.587951498455718d, b: 0.736000484078242d, c: 0.08111086162993775d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.030394613224959732d, b: 0.864877674503466d, c: 0.2856735931232216d),
},
            new NpgsqlLinelineE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9497297271056164d, b: 0.2531894474512395d, c: 0.4173266079140935d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9885773516769343d, b: 0.1843258064999459d, c: 0.9944931646568194d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1234831592565816d, b: 0.787237719530377d, c: 0.39135479808690776d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6427715393485626d, b: 0.5845038400829836d, c: 0.5411973788142919d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7787914063411039d, b: 0.9648880938876946d, c: 0.41066853438288375d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6027469471044712d, b: 0.23680573719158227d, c: 0.1193271873493541d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7252490966572136d, b: 0.13416691617853227d, c: 0.036022819109174486d),
},
            new NpgsqlLinelineE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.16469348265987105d, b: 0.7692460093429052d, c: 0.4481779821433295d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9089915506817238d, b: 0.5052773032810335d, c: 0.24392028973063695d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4228289315810966d, b: 0.9747620567448895d, c: 0.5945611305229005d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5716326720548189d, b: 0.8288843537887369d, c: 0.6619149131942675d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.16064013541732736d, b: 0.564111266220148d, c: 0.818263015195201d),
},
            new NpgsqlLinelineE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6401566090778898d, b: 0.4038740176110931d, c: 0.9877982071957888d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.893287325409988d, b: 0.9426300206527348d, c: 0.1267091822989228d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9028372660339051d, b: 0.8554997884222599d, c: 0.8185824778855992d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2553451495948985d, b: 0.30137914484174944d, c: 0.8429340977073585d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18063017746693588d, b: 0.26923178996114727d, c: 0.13393883995463174d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20601361181440148d, b: 0.5117643752031941d, c: 0.15912132928365375d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7533704518637518d, b: 0.5440399029565929d, c: 0.35670240476696347d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.36395438012141956d, b: 0.48868230477373886d, c: 0.2859641263183609d)));
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
                parametr1.Value = 8;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 81, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 133, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 41, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 81, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 35))
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 58, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[34], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[3], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[4], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[5], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[6], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[7], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[8], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[9], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[10], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[11], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[12], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[13], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[14], false);
                NpgsqlLinelineE0M.AssertModel(models[12],_testData[15], false);
                NpgsqlLinelineE0M.AssertModel(models[13],_testData[16], false);
                NpgsqlLinelineE0M.AssertModel(models[14],_testData[17], false);
                NpgsqlLinelineE0M.AssertModel(models[15],_testData[18], false);
                NpgsqlLinelineE0M.AssertModel(models[16],_testData[19], false);
                NpgsqlLinelineE0M.AssertModel(models[17],_testData[20], false);
                NpgsqlLinelineE0M.AssertModel(models[18],_testData[21], false);
                NpgsqlLinelineE0M.AssertModel(models[19],_testData[22], false);
                NpgsqlLinelineE0M.AssertModel(models[20],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[21],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[22],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[23],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[24],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[25],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[26],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[27],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[28],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[29],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[30],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9709452018966708d, b: 0.4660201073202823d, c: 0.18686965292862945d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1219279280950949d, b: 0.3152025376883978d, c: 0.805261528935731d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4341134590912409d, b: 0.3295865512920264d, c: 0.033002322024837216d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.645418687268759d, b: 0.07150024763206253d, c: 0.20316403636133606d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3572553115182976d, b: 0.3582914823557991d, c: 0.912063071325988d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8062254058955929d, b: 0.0053443485456626805d, c: 0.9737037356753694d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25696784394257255d, b: 0.38598180644051183d, c: 0.8222904991719625d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.250142194314951d, b: 0.3595028081145548d, c: 0.39161672293930794d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8311372849722507d, b: 0.08596997190393307d, c: 0.16625455063837968d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0719468118539126d, b: 0.22433992952614257d, c: 0.3301753003852421d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3723412672435201d, b: 0.7159827237627175d, c: 0.8935646369416627d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1564704093827699d, b: 0.38686433648717367d, c: 0.08214911989117912d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18063017746693588d, b: 0.26923178996114727d, c: 0.13393883995463174d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8729411251941156d, b: 0.9510071671079122d, c: 0.7805403012344102d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20601361181440148d, b: 0.5117643752031941d, c: 0.15912132928365375d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9812446986724748d, b: 0.3215066977527944d, c: 0.15244302231922802d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2997590263816964d, b: 0.1344901506943813d, c: 0.3803536921122196d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.907557337383021d, b: 0.6912403790872849d, c: 0.35398158881418973d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7533704518637518d, b: 0.5440399029565929d, c: 0.35670240476696347d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1286595352815959d, b: 0.5158932045556773d, c: 0.39637871705452643d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3740486864402788d, b: 0.5472865228259144d, c: 0.9085096461923835d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2533423817688929d, b: 0.2709880167322084d, c: 0.9749009206400604d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8805031386747483d, b: 0.0687869353662316d, c: 0.8983521087372126d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48474668197742776d, b: 0.5554236843294613d, c: 0.3480580430629103d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7710121429106387d, b: 0.619710193406977d, c: 0.27069415131327346d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24720485070733256d, b: 0.9610119751670816d, c: 0.9285194728710102d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36395438012141956d, b: 0.48868230477373886d, c: 0.2859641263183609d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12116633761402018d, b: 0.9939040432183426d, c: 0.36608022987343025d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47119801095592373d, b: 0.18003828641434028d, c: 0.36615231832297035d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43377538856179043d, b: 0.35095232026317713d, c: 0.7602685164067796d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9077017295081913d, b: 0.5895746558260463d, c: 0.4703117033864701d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4790084747659613d, b: 0.7623666746109795d, c: 0.36179692937186014d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8379337251361676d, b: 0.2612788067352433d, c: 0.014059516156209928d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.745143456102653d, b: 0.26207887443142464d, c: 0.801112653054045d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28256226415818475d, b: 0.4471725090985006d, c: 0.19308082547388639d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20006951141309537d, b: 0.5138045820101859d, c: 0.5034420748943851d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8688460959362015d, b: 0.4147207778530375d, c: 0.99264937019968d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6237469173245658d, b: 0.950557859823525d, c: 0.6945441540385685d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.97121011523395d, b: 0.823453842614714d, c: 0.3532198093281832d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9374981972680579d, b: 0.17476878524974393d, c: 0.4525272330179825d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.760894685247588d, b: 0.3707516448923187d, c: 0.8368065274087406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2877694097083142d, b: 0.19078302830352478d, c: 0.8179130959911173d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45750978906782014d, b: 0.6288252512678947d, c: 0.32381979173392017d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5747151354523861d, b: 0.10352802213419632d, c: 0.8512271405758918d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7569294980801573d, b: 0.622875472993711d, c: 0.9253755709722811d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6983792312821371d, b: 0.4240569869446634d, c: 0.01629163119939081d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7579549399165759d, b: 0.7186550725601889d, c: 0.031751089428012524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6144560730388233d, b: 0.7292398790519707d, c: 0.6020332098607232d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29666716085075884d, b: 0.09001381056875768d, c: 0.1273937474653407d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23790636159480705d, b: 0.44191129812327656d, c: 0.9408279448430993d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6170950801122617d, b: 0.7881568691654269d, c: 0.5235882865466225d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.539299666913143d, b: 0.9815131847294666d, c: 0.9078035418495987d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5463102743589092d, b: 0.11449185640307791d, c: 0.9449097215802827d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6751028267596737d, b: 0.6874504827407537d, c: 0.5366293449590848d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5649973233121753d, b: 0.937946506714981d, c: 0.6817640209871212d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5916350641947687d, b: 0.12604662543942613d, c: 0.8123961950395521d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2912984489940794d, b: 0.3203822193448812d, c: 0.879578344902394d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.039596455050626145d, b: 0.9993717248161099d, c: 0.7128394680077289d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.587951498455718d, b: 0.736000484078242d, c: 0.08111086162993775d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.030394613224959732d, b: 0.864877674503466d, c: 0.2856735931232216d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9497297271056164d, b: 0.2531894474512395d, c: 0.4173266079140935d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9885773516769343d, b: 0.1843258064999459d, c: 0.9944931646568194d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1234831592565816d, b: 0.787237719530377d, c: 0.39135479808690776d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6427715393485626d, b: 0.5845038400829836d, c: 0.5411973788142919d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7787914063411039d, b: 0.9648880938876946d, c: 0.41066853438288375d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6027469471044712d, b: 0.23680573719158227d, c: 0.1193271873493541d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7252490966572136d, b: 0.13416691617853227d, c: 0.036022819109174486d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16469348265987105d, b: 0.7692460093429052d, c: 0.4481779821433295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9089915506817238d, b: 0.5052773032810335d, c: 0.24392028973063695d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4228289315810966d, b: 0.9747620567448895d, c: 0.5945611305229005d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5716326720548189d, b: 0.8288843537887369d, c: 0.6619149131942675d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16064013541732736d, b: 0.564111266220148d, c: 0.818263015195201d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6401566090778898d, b: 0.4038740176110931d, c: 0.9877982071957888d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.893287325409988d, b: 0.9426300206527348d, c: 0.1267091822989228d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9028372660339051d, b: 0.8554997884222599d, c: 0.8185824778855992d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2553451495948985d, b: 0.30137914484174944d, c: 0.8429340977073585d))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9709452018966708d, b: 0.4660201073202823d, c: 0.18686965292862945d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1219279280950949d, b: 0.3152025376883978d, c: 0.805261528935731d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4341134590912409d, b: 0.3295865512920264d, c: 0.033002322024837216d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.645418687268759d, b: 0.07150024763206253d, c: 0.20316403636133606d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3572553115182976d, b: 0.3582914823557991d, c: 0.912063071325988d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8062254058955929d, b: 0.0053443485456626805d, c: 0.9737037356753694d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25696784394257255d, b: 0.38598180644051183d, c: 0.8222904991719625d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.250142194314951d, b: 0.3595028081145548d, c: 0.39161672293930794d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8311372849722507d, b: 0.08596997190393307d, c: 0.16625455063837968d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0719468118539126d, b: 0.22433992952614257d, c: 0.3301753003852421d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3723412672435201d, b: 0.7159827237627175d, c: 0.8935646369416627d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1564704093827699d, b: 0.38686433648717367d, c: 0.08214911989117912d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18063017746693588d, b: 0.26923178996114727d, c: 0.13393883995463174d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8729411251941156d, b: 0.9510071671079122d, c: 0.7805403012344102d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20601361181440148d, b: 0.5117643752031941d, c: 0.15912132928365375d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9812446986724748d, b: 0.3215066977527944d, c: 0.15244302231922802d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2997590263816964d, b: 0.1344901506943813d, c: 0.3803536921122196d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.907557337383021d, b: 0.6912403790872849d, c: 0.35398158881418973d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7533704518637518d, b: 0.5440399029565929d, c: 0.35670240476696347d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1286595352815959d, b: 0.5158932045556773d, c: 0.39637871705452643d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3740486864402788d, b: 0.5472865228259144d, c: 0.9085096461923835d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2533423817688929d, b: 0.2709880167322084d, c: 0.9749009206400604d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8805031386747483d, b: 0.0687869353662316d, c: 0.8983521087372126d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48474668197742776d, b: 0.5554236843294613d, c: 0.3480580430629103d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7710121429106387d, b: 0.619710193406977d, c: 0.27069415131327346d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24720485070733256d, b: 0.9610119751670816d, c: 0.9285194728710102d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36395438012141956d, b: 0.48868230477373886d, c: 0.2859641263183609d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12116633761402018d, b: 0.9939040432183426d, c: 0.36608022987343025d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47119801095592373d, b: 0.18003828641434028d, c: 0.36615231832297035d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43377538856179043d, b: 0.35095232026317713d, c: 0.7602685164067796d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9077017295081913d, b: 0.5895746558260463d, c: 0.4703117033864701d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4790084747659613d, b: 0.7623666746109795d, c: 0.36179692937186014d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8379337251361676d, b: 0.2612788067352433d, c: 0.014059516156209928d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.745143456102653d, b: 0.26207887443142464d, c: 0.801112653054045d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28256226415818475d, b: 0.4471725090985006d, c: 0.19308082547388639d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20006951141309537d, b: 0.5138045820101859d, c: 0.5034420748943851d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8688460959362015d, b: 0.4147207778530375d, c: 0.99264937019968d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6237469173245658d, b: 0.950557859823525d, c: 0.6945441540385685d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.97121011523395d, b: 0.823453842614714d, c: 0.3532198093281832d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9374981972680579d, b: 0.17476878524974393d, c: 0.4525272330179825d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.760894685247588d, b: 0.3707516448923187d, c: 0.8368065274087406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2877694097083142d, b: 0.19078302830352478d, c: 0.8179130959911173d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45750978906782014d, b: 0.6288252512678947d, c: 0.32381979173392017d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5747151354523861d, b: 0.10352802213419632d, c: 0.8512271405758918d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7569294980801573d, b: 0.622875472993711d, c: 0.9253755709722811d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6983792312821371d, b: 0.4240569869446634d, c: 0.01629163119939081d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7579549399165759d, b: 0.7186550725601889d, c: 0.031751089428012524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6144560730388233d, b: 0.7292398790519707d, c: 0.6020332098607232d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29666716085075884d, b: 0.09001381056875768d, c: 0.1273937474653407d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23790636159480705d, b: 0.44191129812327656d, c: 0.9408279448430993d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6170950801122617d, b: 0.7881568691654269d, c: 0.5235882865466225d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.539299666913143d, b: 0.9815131847294666d, c: 0.9078035418495987d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5463102743589092d, b: 0.11449185640307791d, c: 0.9449097215802827d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6751028267596737d, b: 0.6874504827407537d, c: 0.5366293449590848d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5649973233121753d, b: 0.937946506714981d, c: 0.6817640209871212d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5916350641947687d, b: 0.12604662543942613d, c: 0.8123961950395521d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2912984489940794d, b: 0.3203822193448812d, c: 0.879578344902394d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.039596455050626145d, b: 0.9993717248161099d, c: 0.7128394680077289d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.587951498455718d, b: 0.736000484078242d, c: 0.08111086162993775d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.030394613224959732d, b: 0.864877674503466d, c: 0.2856735931232216d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9497297271056164d, b: 0.2531894474512395d, c: 0.4173266079140935d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9885773516769343d, b: 0.1843258064999459d, c: 0.9944931646568194d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1234831592565816d, b: 0.787237719530377d, c: 0.39135479808690776d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6427715393485626d, b: 0.5845038400829836d, c: 0.5411973788142919d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7787914063411039d, b: 0.9648880938876946d, c: 0.41066853438288375d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6027469471044712d, b: 0.23680573719158227d, c: 0.1193271873493541d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7252490966572136d, b: 0.13416691617853227d, c: 0.036022819109174486d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16469348265987105d, b: 0.7692460093429052d, c: 0.4481779821433295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9089915506817238d, b: 0.5052773032810335d, c: 0.24392028973063695d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4228289315810966d, b: 0.9747620567448895d, c: 0.5945611305229005d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5716326720548189d, b: 0.8288843537887369d, c: 0.6619149131942675d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16064013541732736d, b: 0.564111266220148d, c: 0.818263015195201d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6401566090778898d, b: 0.4038740176110931d, c: 0.9877982071957888d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.893287325409988d, b: 0.9426300206527348d, c: 0.1267091822989228d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9028372660339051d, b: 0.8554997884222599d, c: 0.8185824778855992d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2553451495948985d, b: 0.30137914484174944d, c: 0.8429340977073585d))));//Value

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

