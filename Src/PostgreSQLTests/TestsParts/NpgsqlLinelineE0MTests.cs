

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2123636380350299d, b: 0.034553590517293675d, c: 0.15242934423657772d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08241869125578505d, b: 0.9514585403063649d, c: 0.4244832939614347d),
},
            new NpgsqlLinelineE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.17780875613924274d, b: 0.4176033584100479d, c: 0.7994107122519566d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06157252871494601d, b: 0.16531602676339607d, c: 0.2401639187555038d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1539774878207798d, b: 0.49055971134631127d, c: 0.7309840224962814d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4284281812442561d, b: 0.8108490743462343d, c: 0.643158394368469d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0881642261674257d, b: 0.7324895868655573d, c: 0.5971724364983735d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4137528963082744d, b: 0.7327064148038125d, c: 0.33843131126164727d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4813883329471348d, b: 0.8673918554786471d, c: 0.6337054242793151d),
},
            new NpgsqlLinelineE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5162792266249845d, b: 0.4148353465287318d, c: 0.5687028144479424d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6873050469362108d, b: 0.08459907018794022d, c: 0.4877648001203142d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.430373930614365d, b: 0.7764245380508706d, c: 0.6730133331924142d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4312745059076719d, b: 0.06351365688856325d, c: 0.3832595212512415d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06074522176913566d, b: 0.5908180318327374d, c: 0.7101997524298871d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.43462410782713967d, b: 0.5334146166880813d, c: 0.0028653726072332963d),
},
            new NpgsqlLinelineE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.15329471934264105d, b: 0.0742389117937945d, c: 0.5939004857052185d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4746725920885243d, b: 0.9080316892908231d, c: 0.6502468238257098d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8358917241925914d, b: 0.11980710865524002d, c: 0.9203771173322556d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4190830563126339d, b: 0.05896893134157066d, c: 0.7021950045430182d),
},
            new NpgsqlLinelineE0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.598955823625418d, b: 0.27090956904654495d, c: 0.5649769768949608d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04566585267211376d, b: 0.4100498808001205d, c: 0.8397470498834528d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6592910968677453d, b: 0.40974809689669134d, c: 0.9667229887750212d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3164508062919805d, b: 0.3308442636238603d, c: 0.7308663202084443d),
},
            new NpgsqlLinelineE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4151958562399921d, b: 0.30982974046279366d, c: 0.6463681248484925d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5225503992922367d, b: 0.919495547781161d, c: 0.09486028300248572d),
},
            new NpgsqlLinelineE0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5961214897284242d, b: 0.6338597006472821d, c: 0.5420012497179353d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.33672382251220556d, b: 0.8544456654110475d, c: 0.2524934324496829d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.46209259675130465d, b: 0.8994442758653908d, c: 0.8947353590347388d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9885442802657275d, b: 0.713232564600182d, c: 0.40379706827507733d),
},
            new NpgsqlLinelineE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8802394321608207d, b: 0.5909081659714075d, c: 0.8133026867158734d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3977073088870995d, b: 0.5216866644501096d, c: 0.837492188911878d),
},
            new NpgsqlLinelineE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18859251225292628d, b: 0.44866377001608837d, c: 0.27058447894800586d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5812928064276924d, b: 0.03917258704537008d, c: 0.060193578169589146d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.38512683190665886d, b: 0.5116058305555328d, c: 0.2237301061721474d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7670835409973262d, b: 0.7031769036638866d, c: 0.9688401094915273d),
},
            new NpgsqlLinelineE0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6429247577911358d, b: 0.8424646398931911d, c: 0.5246950615180799d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8702607853738104d, b: 0.8628398342661964d, c: 0.12698628628311992d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8005870351599123d, b: 0.642954013762629d, c: 0.9391474761221779d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6911991836287248d, b: 0.054164557478601716d, c: 0.027945018867636562d),
},
            new NpgsqlLinelineE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24760128867966014d, b: 0.29024776524937834d, c: 0.17231632466796765d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5577950366214653d, b: 0.6137603341385443d, c: 0.7883487346734936d),
},
            new NpgsqlLinelineE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8184571388212657d, b: 0.051887948779273385d, c: 0.9155460561384591d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5705241015979802d, b: 0.29130223795786414d, c: 0.7226012805910419d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7874131185162329d, b: 0.06730589041675417d, c: 0.5816519409685283d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6250979373878127d, b: 0.4154807630228704d, c: 0.5366288716957256d),
},
            new NpgsqlLinelineE0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1622910944889292d, b: 0.7819979383066433d, c: 0.9245113907260191d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4218330780828392d, b: 0.5133006784188842d, c: 0.20506484187799234d),
},
            new NpgsqlLinelineE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5972376326714356d, b: 0.12566990787861365d, c: 0.08615691926005364d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.49020356639660434d, b: 0.6741148402544077d, c: 0.16550241516720854d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8566331588199674d, b: 0.02127167532464913d, c: 0.22988355481341372d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.36397972393559586d, b: 0.11436981387503742d, c: 0.847444682796229d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4400179320023766d, b: 0.7694728940132036d, c: 0.397238783162974d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7264271275839594d, b: 0.21409515635953502d, c: 0.4189808784071112d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20673915150395783d, b: 0.752992562320855d, c: 0.39697468483755516d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7204721160134628d, b: 0.47260916408677534d, c: 0.9830291379475143d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8417461400090136d, b: 0.428389037036749d, c: 0.6060956744341613d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9688382829959936d, b: 0.24983094179426835d, c: 0.09234190206525361d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18219875975252708d, b: 0.5572701532258238d, c: 0.8896525414940969d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1924941054871414d, b: 0.36752457003128225d, c: 0.9583831612527811d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.290506891341176d, b: 0.053011707704102684d, c: 0.8511752873668705d),
},
            new NpgsqlLinelineE0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4866659616031175d, b: 0.8977358433399254d, c: 0.8891201727618177d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7529109586546372d, b: 0.20127508429854046d, c: 0.420652184734442d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8809732265959799d, b: 0.777302085430925d, c: 0.9403770030632522d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7244749271581573d, b: 0.5213675907543963d, c: 0.4619402275526464d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.40822998615620465d, b: 0.5174353243726798d, c: 0.5478771534515952d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.30976365244583637d, b: 0.5896573441659847d, c: 0.9162734253939866d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6929972004403339d, b: 0.579687715037223d, c: 0.7698873213181485d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 185,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9993413415230925d, b: 0.1940814789711902d, c: 0.9594349095934765d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 190,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6808990009224234d, b: 0.9044561696450844d, c: 0.6813125059205085d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5780244155900269d, b: 0.8174060983706164d, c: 0.7358769236201784d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.25605362897572514d, b: 0.7268237078582814d, c: 0.809369428121394d),
},
            new NpgsqlLinelineE0M
{
    Id = 197,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6715330490892943d, b: 0.43864397372684627d, c: 0.19027859976659478d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 203,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6547318697377936d, b: 0.41177068325604516d, c: 0.10207708331121879d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7621614680777937d, b: 0.16136652565767184d, c: 0.4386136742263679d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 212,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8339501367984473d, b: 0.9344068672352505d, c: 0.09992646827250828d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9818344563375087d, b: 0.9262243128742872d, c: 0.7992383915305185d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.43462410782713967d, b: 0.5334146166880813d, c: 0.0028653726072332963d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4190830563126339d, b: 0.05896893134157066d, c: 0.7021950045430182d)));
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3164508062919805d, b: 0.3308442636238603d, c: 0.7308663202084443d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5225503992922367d, b: 0.919495547781161d, c: 0.09486028300248572d)));
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9885442802657275d, b: 0.713232564600182d, c: 0.40379706827507733d)));
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 185;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 117, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 176, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 77, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 125, query1, 171, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 145, query1, 183, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 197, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 176, 125))
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 69, 83))
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 190);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2123636380350299d, b: 0.034553590517293675d, c: 0.15242934423657772d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08241869125578505d, b: 0.9514585403063649d, c: 0.4244832939614347d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17780875613924274d, b: 0.4176033584100479d, c: 0.7994107122519566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06157252871494601d, b: 0.16531602676339607d, c: 0.2401639187555038d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1539774878207798d, b: 0.49055971134631127d, c: 0.7309840224962814d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4284281812442561d, b: 0.8108490743462343d, c: 0.643158394368469d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0881642261674257d, b: 0.7324895868655573d, c: 0.5971724364983735d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4137528963082744d, b: 0.7327064148038125d, c: 0.33843131126164727d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4813883329471348d, b: 0.8673918554786471d, c: 0.6337054242793151d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5162792266249845d, b: 0.4148353465287318d, c: 0.5687028144479424d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6873050469362108d, b: 0.08459907018794022d, c: 0.4877648001203142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.430373930614365d, b: 0.7764245380508706d, c: 0.6730133331924142d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4312745059076719d, b: 0.06351365688856325d, c: 0.3832595212512415d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06074522176913566d, b: 0.5908180318327374d, c: 0.7101997524298871d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43462410782713967d, b: 0.5334146166880813d, c: 0.0028653726072332963d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15329471934264105d, b: 0.0742389117937945d, c: 0.5939004857052185d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4746725920885243d, b: 0.9080316892908231d, c: 0.6502468238257098d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8358917241925914d, b: 0.11980710865524002d, c: 0.9203771173322556d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4190830563126339d, b: 0.05896893134157066d, c: 0.7021950045430182d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.598955823625418d, b: 0.27090956904654495d, c: 0.5649769768949608d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04566585267211376d, b: 0.4100498808001205d, c: 0.8397470498834528d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6592910968677453d, b: 0.40974809689669134d, c: 0.9667229887750212d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3164508062919805d, b: 0.3308442636238603d, c: 0.7308663202084443d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4151958562399921d, b: 0.30982974046279366d, c: 0.6463681248484925d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5225503992922367d, b: 0.919495547781161d, c: 0.09486028300248572d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5961214897284242d, b: 0.6338597006472821d, c: 0.5420012497179353d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33672382251220556d, b: 0.8544456654110475d, c: 0.2524934324496829d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46209259675130465d, b: 0.8994442758653908d, c: 0.8947353590347388d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9885442802657275d, b: 0.713232564600182d, c: 0.40379706827507733d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8802394321608207d, b: 0.5909081659714075d, c: 0.8133026867158734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3977073088870995d, b: 0.5216866644501096d, c: 0.837492188911878d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18859251225292628d, b: 0.44866377001608837d, c: 0.27058447894800586d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5812928064276924d, b: 0.03917258704537008d, c: 0.060193578169589146d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38512683190665886d, b: 0.5116058305555328d, c: 0.2237301061721474d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7670835409973262d, b: 0.7031769036638866d, c: 0.9688401094915273d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6429247577911358d, b: 0.8424646398931911d, c: 0.5246950615180799d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8702607853738104d, b: 0.8628398342661964d, c: 0.12698628628311992d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8005870351599123d, b: 0.642954013762629d, c: 0.9391474761221779d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6911991836287248d, b: 0.054164557478601716d, c: 0.027945018867636562d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24760128867966014d, b: 0.29024776524937834d, c: 0.17231632466796765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5577950366214653d, b: 0.6137603341385443d, c: 0.7883487346734936d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8184571388212657d, b: 0.051887948779273385d, c: 0.9155460561384591d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5705241015979802d, b: 0.29130223795786414d, c: 0.7226012805910419d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7874131185162329d, b: 0.06730589041675417d, c: 0.5816519409685283d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6250979373878127d, b: 0.4154807630228704d, c: 0.5366288716957256d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1622910944889292d, b: 0.7819979383066433d, c: 0.9245113907260191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4218330780828392d, b: 0.5133006784188842d, c: 0.20506484187799234d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5972376326714356d, b: 0.12566990787861365d, c: 0.08615691926005364d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49020356639660434d, b: 0.6741148402544077d, c: 0.16550241516720854d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8566331588199674d, b: 0.02127167532464913d, c: 0.22988355481341372d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36397972393559586d, b: 0.11436981387503742d, c: 0.847444682796229d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4400179320023766d, b: 0.7694728940132036d, c: 0.397238783162974d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7264271275839594d, b: 0.21409515635953502d, c: 0.4189808784071112d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20673915150395783d, b: 0.752992562320855d, c: 0.39697468483755516d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7204721160134628d, b: 0.47260916408677534d, c: 0.9830291379475143d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8417461400090136d, b: 0.428389037036749d, c: 0.6060956744341613d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9688382829959936d, b: 0.24983094179426835d, c: 0.09234190206525361d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18219875975252708d, b: 0.5572701532258238d, c: 0.8896525414940969d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1924941054871414d, b: 0.36752457003128225d, c: 0.9583831612527811d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.290506891341176d, b: 0.053011707704102684d, c: 0.8511752873668705d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4866659616031175d, b: 0.8977358433399254d, c: 0.8891201727618177d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7529109586546372d, b: 0.20127508429854046d, c: 0.420652184734442d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8809732265959799d, b: 0.777302085430925d, c: 0.9403770030632522d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7244749271581573d, b: 0.5213675907543963d, c: 0.4619402275526464d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40822998615620465d, b: 0.5174353243726798d, c: 0.5478771534515952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.30976365244583637d, b: 0.5896573441659847d, c: 0.9162734253939866d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6929972004403339d, b: 0.579687715037223d, c: 0.7698873213181485d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9993413415230925d, b: 0.1940814789711902d, c: 0.9594349095934765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6808990009224234d, b: 0.9044561696450844d, c: 0.6813125059205085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5780244155900269d, b: 0.8174060983706164d, c: 0.7358769236201784d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25605362897572514d, b: 0.7268237078582814d, c: 0.809369428121394d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((197)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6715330490892943d, b: 0.43864397372684627d, c: 0.19027859976659478d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((203)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6547318697377936d, b: 0.41177068325604516d, c: 0.10207708331121879d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7621614680777937d, b: 0.16136652565767184d, c: 0.4386136742263679d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((212)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8339501367984473d, b: 0.9344068672352505d, c: 0.09992646827250828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9818344563375087d, b: 0.9262243128742872d, c: 0.7992383915305185d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2123636380350299d, b: 0.034553590517293675d, c: 0.15242934423657772d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08241869125578505d, b: 0.9514585403063649d, c: 0.4244832939614347d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17780875613924274d, b: 0.4176033584100479d, c: 0.7994107122519566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06157252871494601d, b: 0.16531602676339607d, c: 0.2401639187555038d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1539774878207798d, b: 0.49055971134631127d, c: 0.7309840224962814d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4284281812442561d, b: 0.8108490743462343d, c: 0.643158394368469d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0881642261674257d, b: 0.7324895868655573d, c: 0.5971724364983735d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4137528963082744d, b: 0.7327064148038125d, c: 0.33843131126164727d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4813883329471348d, b: 0.8673918554786471d, c: 0.6337054242793151d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5162792266249845d, b: 0.4148353465287318d, c: 0.5687028144479424d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6873050469362108d, b: 0.08459907018794022d, c: 0.4877648001203142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.430373930614365d, b: 0.7764245380508706d, c: 0.6730133331924142d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4312745059076719d, b: 0.06351365688856325d, c: 0.3832595212512415d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06074522176913566d, b: 0.5908180318327374d, c: 0.7101997524298871d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43462410782713967d, b: 0.5334146166880813d, c: 0.0028653726072332963d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15329471934264105d, b: 0.0742389117937945d, c: 0.5939004857052185d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4746725920885243d, b: 0.9080316892908231d, c: 0.6502468238257098d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8358917241925914d, b: 0.11980710865524002d, c: 0.9203771173322556d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4190830563126339d, b: 0.05896893134157066d, c: 0.7021950045430182d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.598955823625418d, b: 0.27090956904654495d, c: 0.5649769768949608d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04566585267211376d, b: 0.4100498808001205d, c: 0.8397470498834528d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6592910968677453d, b: 0.40974809689669134d, c: 0.9667229887750212d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3164508062919805d, b: 0.3308442636238603d, c: 0.7308663202084443d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4151958562399921d, b: 0.30982974046279366d, c: 0.6463681248484925d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5225503992922367d, b: 0.919495547781161d, c: 0.09486028300248572d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5961214897284242d, b: 0.6338597006472821d, c: 0.5420012497179353d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33672382251220556d, b: 0.8544456654110475d, c: 0.2524934324496829d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46209259675130465d, b: 0.8994442758653908d, c: 0.8947353590347388d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9885442802657275d, b: 0.713232564600182d, c: 0.40379706827507733d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8802394321608207d, b: 0.5909081659714075d, c: 0.8133026867158734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3977073088870995d, b: 0.5216866644501096d, c: 0.837492188911878d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18859251225292628d, b: 0.44866377001608837d, c: 0.27058447894800586d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5812928064276924d, b: 0.03917258704537008d, c: 0.060193578169589146d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38512683190665886d, b: 0.5116058305555328d, c: 0.2237301061721474d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7670835409973262d, b: 0.7031769036638866d, c: 0.9688401094915273d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6429247577911358d, b: 0.8424646398931911d, c: 0.5246950615180799d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8702607853738104d, b: 0.8628398342661964d, c: 0.12698628628311992d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8005870351599123d, b: 0.642954013762629d, c: 0.9391474761221779d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6911991836287248d, b: 0.054164557478601716d, c: 0.027945018867636562d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24760128867966014d, b: 0.29024776524937834d, c: 0.17231632466796765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5577950366214653d, b: 0.6137603341385443d, c: 0.7883487346734936d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8184571388212657d, b: 0.051887948779273385d, c: 0.9155460561384591d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5705241015979802d, b: 0.29130223795786414d, c: 0.7226012805910419d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7874131185162329d, b: 0.06730589041675417d, c: 0.5816519409685283d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6250979373878127d, b: 0.4154807630228704d, c: 0.5366288716957256d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1622910944889292d, b: 0.7819979383066433d, c: 0.9245113907260191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4218330780828392d, b: 0.5133006784188842d, c: 0.20506484187799234d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5972376326714356d, b: 0.12566990787861365d, c: 0.08615691926005364d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49020356639660434d, b: 0.6741148402544077d, c: 0.16550241516720854d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8566331588199674d, b: 0.02127167532464913d, c: 0.22988355481341372d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36397972393559586d, b: 0.11436981387503742d, c: 0.847444682796229d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4400179320023766d, b: 0.7694728940132036d, c: 0.397238783162974d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7264271275839594d, b: 0.21409515635953502d, c: 0.4189808784071112d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20673915150395783d, b: 0.752992562320855d, c: 0.39697468483755516d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7204721160134628d, b: 0.47260916408677534d, c: 0.9830291379475143d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8417461400090136d, b: 0.428389037036749d, c: 0.6060956744341613d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9688382829959936d, b: 0.24983094179426835d, c: 0.09234190206525361d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18219875975252708d, b: 0.5572701532258238d, c: 0.8896525414940969d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1924941054871414d, b: 0.36752457003128225d, c: 0.9583831612527811d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.290506891341176d, b: 0.053011707704102684d, c: 0.8511752873668705d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4866659616031175d, b: 0.8977358433399254d, c: 0.8891201727618177d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7529109586546372d, b: 0.20127508429854046d, c: 0.420652184734442d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8809732265959799d, b: 0.777302085430925d, c: 0.9403770030632522d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7244749271581573d, b: 0.5213675907543963d, c: 0.4619402275526464d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40822998615620465d, b: 0.5174353243726798d, c: 0.5478771534515952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.30976365244583637d, b: 0.5896573441659847d, c: 0.9162734253939866d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6929972004403339d, b: 0.579687715037223d, c: 0.7698873213181485d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9993413415230925d, b: 0.1940814789711902d, c: 0.9594349095934765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6808990009224234d, b: 0.9044561696450844d, c: 0.6813125059205085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5780244155900269d, b: 0.8174060983706164d, c: 0.7358769236201784d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25605362897572514d, b: 0.7268237078582814d, c: 0.809369428121394d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((197)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6715330490892943d, b: 0.43864397372684627d, c: 0.19027859976659478d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((203)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6547318697377936d, b: 0.41177068325604516d, c: 0.10207708331121879d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7621614680777937d, b: 0.16136652565767184d, c: 0.4386136742263679d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((212)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8339501367984473d, b: 0.9344068672352505d, c: 0.09992646827250828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9818344563375087d, b: 0.9262243128742872d, c: 0.7992383915305185d))));

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

