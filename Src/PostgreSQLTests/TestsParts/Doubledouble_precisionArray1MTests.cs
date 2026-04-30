

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
    Id = 3,
    Value = 
new System.Double[3]
{
0.3366820217938178d,
0.18662548031046455d,
0.009721096184423073d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3172126575480788d,
0.6433071889237496d,
0.7849964108470165d,
0.6512200993645925d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 6,
    Value = 
new System.Double[3]
{
0.9418046512601815d,
0.19056834922836996d,
0.7517859055173024d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 5,
    Value = 
new System.Double[4]
{
0.3474652796556018d,
0.8495586413627927d,
0.7298441149340272d,
0.9227561684421809d,
},
    NullableValue = 
new System.Double[3]
{
0.373841635324635d,
0.7004102668507999d,
0.05727635684368659d,
},
},
    NullableValue = 
new System.Double[4]
{
0.5120249998681041d,
0.7875365062974197d,
0.37833052326013483d,
0.3584436885785296d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.659812691941483d,
0.6564802284999393d,
0.1192866352262757d,
0.05871004608695152d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 17,
    Value = 
new System.Double[4]
{
0.08308183979590755d,
0.5815810196170089d,
0.014908374361800592d,
0.7568556529583452d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 11,
    Value = 
new System.Double[4]
{
0.1146452723092064d,
0.020218564659770344d,
0.7941499973157911d,
0.5712790916628244d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.2770026496499771d,
0.6727483013499513d,
0.8839581248652445d,
0.7814792631954325d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 24,
    Value = 
new System.Double[3]
{
0.7357637911372853d,
0.5283689632451658d,
0.6141029734789987d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 30,
    Value = 
new System.Double[4]
{
0.4071149543008643d,
0.5237222335045598d,
0.6791951592254121d,
0.22974760649466353d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.700210810462135d,
0.9188496192666584d,
0.7110969123031062d,
0.8150884243457289d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 39,
    Value = 
new System.Double[4]
{
0.6097749111681043d,
0.10638658731422623d,
0.816933917666176d,
0.2889810612238607d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 45,
    Value = 
new System.Double[3]
{
0.07594751470474481d,
0.7918169507965281d,
0.8794655632365257d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 18,
    Value = 
new System.Double[3]
{
0.3503229547449498d,
0.5107734875904417d,
0.8567541888015923d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5013089743114179d,
0.07684257537840933d,
0.5653322528325352d,
0.1938498637414069d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 52,
    Value = 
new System.Double[3]
{
0.3332096559154325d,
0.3425540465951309d,
0.6439156949407748d,
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
0.3957865866888668d,
0.1746135957615591d,
0.15337982708613163d,
0.5213791554972937d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 24,
    Value = 
new System.Double[4]
{
0.6554906585341532d,
0.8128666960338627d,
0.954552941988567d,
0.5697528445390713d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.8820954056090572d,
0.2051208634453654d,
0.4424195193318774d,
0.9113377816842873d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.7303186580793651d,
0.42505418883769097d,
0.17894270195547712d,
0.9629823245734144d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 64,
    Value = 
new System.Double[3]
{
0.5609183182276816d,
0.9734047550380718d,
0.7740053330124593d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 33,
    Value = 
new System.Double[4]
{
0.4985050120361938d,
0.9176351125917273d,
0.17376786140402023d,
0.9490629746962718d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.34934326785155434d,
0.6914650565463731d,
0.9212251130756175d,
0.31714657872577645d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 67,
    Value = 
new System.Double[3]
{
0.03936343922633634d,
0.32977069579088913d,
0.5831904244336178d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 72,
    Value = 
new System.Double[4]
{
0.18570731743333424d,
0.6484214746586046d,
0.0750427295420969d,
0.2302809190037607d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 42,
    Value = 
new System.Double[3]
{
0.9289019407183372d,
0.010390103761892533d,
0.509644373684243d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.7885568597642896d,
0.7052424628034276d,
0.1728023466132158d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 75,
    Value = 
new System.Double[4]
{
0.40783079013489143d,
0.10371135955450239d,
0.5437228137792416d,
0.8893111399004228d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9360531423690956d,
0.48598533931532373d,
0.10384361090969563d,
0.3071433447887262d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 76,
    Value = 
new System.Double[3]
{
0.05964511135468409d,
0.6708029746683243d,
0.6250521465026828d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 48,
    Value = 
new System.Double[3]
{
0.4533131099165343d,
0.7633761496497248d,
0.17163441478501484d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 79,
    Value = 
new System.Double[4]
{
0.8598142260741183d,
0.6416784902606714d,
0.9577938622612647d,
0.944893055007665d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 86,
    Value = 
new System.Double[3]
{
0.4082734857660928d,
0.28581112202405357d,
0.8369586938716592d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 50,
    Value = 
new System.Double[4]
{
0.14036029492770707d,
0.88919613967671d,
0.20855524080297494d,
0.30092802034092025d,
},
    NullableValue = 
new System.Double[3]
{
0.9858047955745488d,
0.370562162419369d,
0.9497143668349114d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 94,
    Value = 
new System.Double[3]
{
0.8449249255222978d,
0.4277862012375112d,
0.8747785886912329d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 101,
    Value = 
new System.Double[3]
{
0.36357277180496317d,
0.7595216054602141d,
0.17587179188634794d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 58,
    Value = 
new System.Double[3]
{
0.2944781539275766d,
0.7768657990678713d,
0.29583464851728236d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.4036166144379615d,
0.38630514802906457d,
0.5677366938365138d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 109,
    Value = 
new System.Double[4]
{
0.2968538121007789d,
0.7886023941837192d,
0.47192576700635547d,
0.6087448002816894d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8514336096461123d,
0.5641856995324352d,
0.353977500953064d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 115,
    Value = 
new System.Double[4]
{
0.043056332083452165d,
0.02275967386199329d,
0.4747104458144815d,
0.6213627623857414d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 65,
    Value = 
new System.Double[3]
{
0.3278358282316639d,
0.7514431163006446d,
0.4002146350361464d,
},
    NullableValue = 
new System.Double[3]
{
0.8988419048374573d,
0.19882542942869386d,
0.6745409942134155d,
},
},
    NullableValue = 
new System.Double[3]
{
0.6176998811896339d,
0.9522167709416397d,
0.5734536212695949d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 120,
    Value = 
new System.Double[3]
{
0.932886747461945d,
0.6987485244952533d,
0.916084388299953d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 122,
    Value = 
new System.Double[3]
{
0.12427425830827754d,
0.6889891336030705d,
0.6531076053504603d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 68,
    Value = 
new System.Double[4]
{
0.21720324439433103d,
0.9382939206347749d,
0.8472509096131855d,
0.46758448829693444d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 131,
    Value = 
new System.Double[3]
{
0.001447050837403152d,
0.8626540665014332d,
0.8015136300226556d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 134,
    Value = 
new System.Double[3]
{
0.6476803535810658d,
0.11049736430730905d,
0.7017455374887421d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 73,
    Value = 
new System.Double[4]
{
0.35868648485891597d,
0.25671225933744d,
0.416586486910855d,
0.5832480315292622d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5886450227040353d,
0.24095763379808255d,
0.7955615701465144d,
0.830195960915173d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 135,
    Value = 
new System.Double[3]
{
0.502558803488933d,
0.7064565846189754d,
0.43714087348220776d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 137,
    Value = 
new System.Double[3]
{
0.3640789933962859d,
0.4753133665369196d,
0.19088759860190874d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 77,
    Value = 
new System.Double[4]
{
0.434747483903993d,
0.4426069831403421d,
0.7467334222130333d,
0.7332831262903166d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.7843686298805053d,
0.6603675794279953d,
0.7002693783269225d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.3655010649785244d,
0.06583035698327855d,
0.6387022329440433d,
0.043479460028723604d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.21988664231045907d,
0.179977035106469d,
0.5584150350265322d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 147,
    Value = 
new System.Double[3]
{
0.6262185386536401d,
0.7421979746754236d,
0.3336663056488933d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 79,
    Value = 
new System.Double[4]
{
0.40607521094974497d,
0.5054686996941776d,
0.05563615955943957d,
0.14193486454353732d,
},
    NullableValue = null,
},
    NullableValue = null,
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
0.5013089743114179d,
0.07684257537840933d,
0.5653322528325352d,
0.1938498637414069d,
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.8820954056090572d,
0.2051208634453654d,
0.4424195193318774d,
0.9113377816842873d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.34934326785155434d,
0.6914650565463731d,
0.9212251130756175d,
0.31714657872577645d,
}));
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 135, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 30, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 134, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 30, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(Doubledouble_precisionArray1MI),
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
            queryMapType: typeof(Doubledouble_precisionArray1M),
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

