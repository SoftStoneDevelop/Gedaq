

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
    internal partial interface IDoubleArraydouble_precisionArray
    {
    }
    
    internal partial class DoubleArraydouble_precisionArray : IDoubleArraydouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray1M[] _testData = new Doubledouble_precisionArray1M[]
        {
            new Doubledouble_precisionArray1M
{
    Id = 1,
    Value = 
new System.Double[3]
{
0.30567185506768435d,
0.7316597280392179d,
0.4735305489871243d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5920869590778624d,
0.9749645587930902d,
0.6599451291726596d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 4,
    Value = 
new System.Double[3]
{
0.6647922029183609d,
0.4882450635655746d,
0.46092857412222243d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 1,
    Value = 
new System.Double[3]
{
0.7493580894931673d,
0.5270495236648479d,
0.4579970551701339d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.5322726206620007d,
0.21659745452509183d,
0.6188967146229349d,
0.3113528482243788d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8557438851433026d,
0.3864227261526286d,
0.22213004608648934d,
0.8723728432589419d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 14,
    Value = 
new System.Double[3]
{
0.0852719660806246d,
0.4388471195360657d,
0.30363744543200155d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 8,
    Value = 
new System.Double[4]
{
0.6615636973396094d,
0.41540377674758966d,
0.7426259606012435d,
0.7589645555284852d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.0689680700383658d,
0.6722305566079394d,
0.8270881696546627d,
0.3092143725700568d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 19,
    Value = 
new System.Double[4]
{
0.6366567465520292d,
0.4138220746125135d,
0.038759220656952253d,
0.69494162278863d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 25,
    Value = 
new System.Double[4]
{
0.7851428699091968d,
0.5086523458700538d,
0.8500757259299087d,
0.8366788829821982d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 11,
    Value = 
new System.Double[4]
{
0.015103641264959111d,
0.27721126217967174d,
0.7087820380975123d,
0.9761292772940462d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 34,
    Value = 
new System.Double[4]
{
0.09465818996873232d,
0.6952222671688227d,
0.6171171544550452d,
0.5309365491306414d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 43,
    Value = 
new System.Double[3]
{
0.5077467304820195d,
0.4697541601888927d,
0.5308520644573225d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 14,
    Value = 
new System.Double[4]
{
0.9532073272110424d,
0.49035019546002434d,
0.8973372922521078d,
0.6129281168433773d,
},
    NullableValue = 
new System.Double[3]
{
0.31257018317036445d,
0.684529122126818d,
0.4670083554138651d,
},
},
    NullableValue = 
new System.Double[4]
{
0.46972410058778036d,
0.4615888834930525d,
0.04555036322329209d,
0.5754132377897206d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 45,
    Value = 
new System.Double[3]
{
0.650486413644145d,
0.9264673830063594d,
0.889426442134697d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.33012925278983896d,
0.14679373923209682d,
0.18427907198476867d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 50,
    Value = 
new System.Double[4]
{
0.20415684529908984d,
0.5735126293679743d,
0.9730877543662252d,
0.38598331327856794d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 20,
    Value = 
new System.Double[4]
{
0.08512410594478892d,
0.10026579544460368d,
0.1269342749265645d,
0.12322169873303779d,
},
    NullableValue = 
new System.Double[3]
{
0.00964482505336206d,
0.8837759823516861d,
0.21149077560755103d,
},
},
    NullableValue = 
new System.Double[4]
{
0.06323708809552886d,
0.1936707612416777d,
0.33499718949389534d,
0.7214079889427336d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 55,
    Value = 
new System.Double[4]
{
0.5060019456723874d,
0.8884645801706296d,
0.11843340633482824d,
0.8831107262463929d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.7338514566851017d,
0.27921214729547206d,
0.17024221976378684d,
0.35357656279811367d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 26,
    Value = 
new System.Double[3]
{
0.2993561564981927d,
0.49128744467104324d,
0.6248821443676884d,
},
    NullableValue = 
new System.Double[4]
{
0.5770245922584735d,
0.5248680272101457d,
0.5183508727818934d,
0.97072762184491d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 59,
    Value = 
new System.Double[4]
{
0.013631403451568547d,
0.8282314888987843d,
0.7485431403752529d,
0.623263856576006d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.22968641385939326d,
0.45328795765533547d,
0.425428363476994d,
0.205615067633653d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.33167811945119985d,
0.9992227290851818d,
0.18360483993866583d,
0.4888363625098039d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.3613726367687844d,
0.6464033952914661d,
0.1914313364778082d,
0.4225877113318228d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.8479931150826889d,
0.4172475269920052d,
0.09714063717585864d,
0.5660483280461897d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 64,
    Value = 
new System.Double[3]
{
0.8268348017623632d,
0.35706485274697186d,
0.7417140707638605d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.935942874889308d,
0.7167956680004051d,
0.6192757493513571d,
0.06385473053140456d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 71,
    Value = 
new System.Double[4]
{
0.33226048910810146d,
0.4316863402673413d,
0.9965468077381557d,
0.481371343923198d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.7020458350072984d,
0.035794174547371105d,
0.17318835737305072d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.7523633815047912d,
0.5688626628835614d,
0.2706126259539391d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 74,
    Value = 
new System.Double[3]
{
0.20922952579070908d,
0.2740065205525246d,
0.5238530913253472d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.21544801142224512d,
0.5356210573544101d,
0.6217118674598412d,
0.9730402120645699d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.8219224544605175d,
0.7973725113541186d,
0.08400207880009947d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 42,
    Value = 
new System.Double[4]
{
0.4809453402222137d,
0.7060977750035807d,
0.8990004211333193d,
0.5351730920611861d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.6165569406143672d,
0.0067046935553124465d,
0.9977837589969535d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 77,
    Value = 
new System.Double[3]
{
0.10928282286991786d,
0.6043026398451411d,
0.2765051143596148d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8360414036629172d,
0.126573280390875d,
0.30553168384319074d,
0.22774509398238096d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 82,
    Value = 
new System.Double[3]
{
0.17864494206577963d,
0.9555656091976883d,
0.7909192871204129d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 51,
    Value = 
new System.Double[4]
{
0.5674605549312163d,
0.12688952498721195d,
0.04049768625544703d,
0.5589885064464937d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.3411311372720026d,
0.07602092949133532d,
0.06781525948911793d,
0.3397858229365486d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 86,
    Value = 
new System.Double[3]
{
0.15564891733959407d,
0.07811054093293235d,
0.3725937754710934d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 93,
    Value = 
new System.Double[3]
{
0.9865160285613711d,
0.4813262573609939d,
0.5250339407740148d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 53,
    Value = 
new System.Double[4]
{
0.043744550945551075d,
0.19366443441644943d,
0.8431450301630464d,
0.0817012706561906d,
},
    NullableValue = 
new System.Double[3]
{
0.7878358018859336d,
0.5598699799915035d,
0.2499049277118791d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 97,
    Value = 
new System.Double[4]
{
0.5463152085329153d,
0.2671362278988957d,
0.7880386851006371d,
0.9308974829111537d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.44811269268239795d,
0.6875614326734618d,
0.4779866558196344d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 101,
    Value = 
new System.Double[4]
{
0.866258062560069d,
0.005792644484929221d,
0.21483388291216055d,
0.558343021610466d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 59,
    Value = 
new System.Double[3]
{
0.6823412550333858d,
0.6720533881914437d,
0.7405748330349469d,
},
    NullableValue = 
new System.Double[4]
{
0.7964342350256803d,
0.4479607412334752d,
0.3209654971879454d,
0.2916813878855662d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 109,
    Value = 
new System.Double[3]
{
0.19470625549372977d,
0.15865645770699843d,
0.6201009622208353d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 113,
    Value = 
new System.Double[3]
{
0.3450971228178953d,
0.6991723972102546d,
0.11503649732007315d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 61,
    Value = 
new System.Double[3]
{
0.0959403201720096d,
0.8414151851723682d,
0.4213017704800731d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 121,
    Value = 
new System.Double[3]
{
0.6355872054952401d,
0.8626981756036094d,
0.15951467991240742d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.1818459622063019d,
0.5282805613373439d,
0.8860151678353532d,
0.3200918306315168d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 125,
    Value = 
new System.Double[4]
{
0.6425628352361906d,
0.5125247786160114d,
0.18071073459337017d,
0.8450593909547468d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 62,
    Value = 
new System.Double[4]
{
0.0309316749060069d,
0.9282269215940446d,
0.5345396691757999d,
0.6601219482585621d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 131,
    Value = 
new System.Double[4]
{
0.8178089025812983d,
0.24580905619150262d,
0.6453081415722379d,
0.16803846300626768d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9472916713573638d,
0.9563200616339443d,
0.8333407273303262d,
0.8044982027217629d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.33855812835796273d,
0.9666981198185226d,
0.8423443083997723d,
0.6555004998049903d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 68,
    Value = 
new System.Double[3]
{
0.6847766346293858d,
0.17824618421890714d,
0.2690857329449112d,
},
    NullableValue = 
new System.Double[3]
{
0.21133373616544116d,
0.02655448179058606d,
0.885073034315475d,
},
},
    NullableValue = 
new System.Double[3]
{
0.10349481315001774d,
0.5745261856199492d,
0.47723278623056764d,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.46972410058778036d,
0.4615888834930525d,
0.04555036322329209d,
0.5754132377897206d,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.33012925278983896d,
0.14679373923209682d,
0.18427907198476867d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.06323708809552886d,
0.1936707612416777d,
0.33499718949389534d,
0.7214079889427336d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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

                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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

                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
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

                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 25, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 34, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
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
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 45, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
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
                await using var cmd = await ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[2], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[3], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[4], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[5], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[6], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[24],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[25],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[26],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1m m
LEFT JOIN public.binary_doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1M>(15);

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
                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

