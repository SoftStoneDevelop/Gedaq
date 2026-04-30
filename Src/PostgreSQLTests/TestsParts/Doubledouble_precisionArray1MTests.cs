

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
    Id = 7,
    Value = 
new System.Double[3]
{
0.537713904341762d,
0.632316768630028d,
0.26134489900465574d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.07691424452636086d,
0.5504423253983725d,
0.7497704490333934d,
0.6077648777662721d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.4179730329863449d,
0.7394995425759654d,
0.1638706316320826d,
0.3790858225746935d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.4104008850647535d,
0.2758347861825978d,
0.9478559027061224d,
0.8108249314042313d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 17,
    Value = 
new System.Double[4]
{
0.8222427835507248d,
0.5353156020485959d,
0.8799628098515405d,
0.1776215685503585d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 19,
    Value = 
new System.Double[4]
{
0.6463234824837734d,
0.5033335612660904d,
0.8332674658086496d,
0.45329128628865756d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.8568322652773607d,
0.9681385832280878d,
0.8062485031646057d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.2911159939226602d,
0.884275251917331d,
0.358221300331266d,
0.7702107529272855d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 23,
    Value = 
new System.Double[3]
{
0.9945521802392487d,
0.38496929768563815d,
0.7272182607323919d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.42979224837001617d,
0.7554975951592688d,
0.3134220285076318d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 30,
    Value = 
new System.Double[4]
{
0.5765599227289504d,
0.17804957731659643d,
0.5939910233097979d,
0.37452290034451474d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.49829563000698873d,
0.16992873006749765d,
0.5877354629781407d,
0.051778086871228646d,
},
    NullableValue = 
new System.Double[3]
{
0.22348375215245464d,
0.06697302608446654d,
0.7027323560889933d,
},
},
    NullableValue = 
new System.Double[3]
{
0.6360717014690606d,
0.8375935450649699d,
0.6807442796083972d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.7773571494560467d,
0.05900605541680637d,
0.1074848754602784d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 35,
    Value = 
new System.Double[3]
{
0.2892253809913462d,
0.45867336362897015d,
0.33582391213645935d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 18,
    Value = 
new System.Double[3]
{
0.7924075920875145d,
0.6195149632416652d,
0.5973272593041978d,
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
0.016564674773801413d,
0.17908517927134793d,
0.3726065850956206d,
0.7824472759185889d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.2870871493289868d,
0.5046699440219514d,
0.4325627958480527d,
0.4215733466079844d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 41,
    Value = 
new System.Double[4]
{
0.284242905690123d,
0.14640170838488664d,
0.38043886713181163d,
0.9749877733142029d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 22,
    Value = 
new System.Double[3]
{
0.9943990879982093d,
0.9548575538756333d,
0.6468420080065287d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.9445042992295818d,
0.33226257160327255d,
0.2608729863742115d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 45,
    Value = 
new System.Double[4]
{
0.1736544572508456d,
0.2360638084049944d,
0.9457963371568886d,
0.1683904640834838d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.10838698104134903d,
0.8826031517073103d,
0.31506235330914933d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.04693505249058705d,
0.35173460898927755d,
0.2802798275125511d,
0.92730686202113d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.6573054341612007d,
0.678673828918431d,
0.7280483500563972d,
0.401430467255941d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.7599307284973448d,
0.5205594751743357d,
0.4256612245033894d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.3314591455012752d,
0.6153666154341622d,
0.551658427664905d,
0.5051040470361865d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.6124398166246476d,
0.8708441015745755d,
0.5960361511639276d,
0.8554292864022751d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 30,
    Value = 
new System.Double[3]
{
0.45846661120097454d,
0.5927160146469761d,
0.9164252543152844d,
},
    NullableValue = 
new System.Double[3]
{
0.5705068076176327d,
0.21462723503966263d,
0.13948681832350607d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 67,
    Value = 
new System.Double[4]
{
0.24791066113730642d,
0.2863397643097324d,
0.539811624084597d,
0.20686064863054598d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 76,
    Value = 
new System.Double[4]
{
0.03679238930756634d,
0.5284684805709808d,
0.7453655251070674d,
0.7086293018498503d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 36,
    Value = 
new System.Double[4]
{
0.6202913131261881d,
0.33229200409360016d,
0.141033437462179d,
0.027255753816035844d,
},
    NullableValue = 
new System.Double[4]
{
0.46155707329516193d,
0.08985238534581141d,
0.8783618401407697d,
0.27615810681118624d,
},
},
    NullableValue = 
new System.Double[4]
{
0.48103434697553504d,
0.9367254748341105d,
0.9262872808251527d,
0.8897858607679733d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.6594202742873649d,
0.703205274939222d,
0.7550214569952803d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 87,
    Value = 
new System.Double[3]
{
0.06484716768958465d,
0.5421596769290961d,
0.1160279389895339d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 42,
    Value = 
new System.Double[3]
{
0.7929720591135342d,
0.12397841666401943d,
0.5211487078638778d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.9001360396580365d,
0.6759956553784595d,
0.7509051146124991d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 96,
    Value = 
new System.Double[4]
{
0.5064445653008061d,
0.10763815289807044d,
0.9730644299453899d,
0.8294360919941176d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 103,
    Value = 
new System.Double[3]
{
0.44134141494286183d,
0.28100534833885793d,
0.3311815414394632d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 48,
    Value = 
new System.Double[4]
{
0.09865578400469577d,
0.26823688751924046d,
0.9518470992292059d,
0.21474438745216706d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 110,
    Value = 
new System.Double[4]
{
0.9807432152683121d,
0.725487489337251d,
0.3618919911840659d,
0.4037520913004128d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9308063837545326d,
0.5079758990291264d,
0.3601610101918973d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 118,
    Value = 
new System.Double[3]
{
0.4046901117706889d,
0.107873076988097d,
0.3108917326841336d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 52,
    Value = 
new System.Double[4]
{
0.8496331160306041d,
0.5642170598972748d,
0.31161455062002696d,
0.3310335307222757d,
},
    NullableValue = 
new System.Double[3]
{
0.9453045815184825d,
0.9822693611648154d,
0.9553905105624434d,
},
},
    NullableValue = 
new System.Double[4]
{
0.20024883230101675d,
0.9448799160516733d,
0.5698606432289374d,
0.9634341477167501d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 121,
    Value = 
new System.Double[3]
{
0.7560634906200137d,
0.14117067871487154d,
0.05961993888323325d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 127,
    Value = 
new System.Double[4]
{
0.1663991315253539d,
0.0433156140419253d,
0.3459722042433515d,
0.756524417024484d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 55,
    Value = 
new System.Double[3]
{
0.54602598177611d,
0.34719993137024563d,
0.2867739629964139d,
},
    NullableValue = 
new System.Double[3]
{
0.5790034807595439d,
0.5720664156673854d,
0.4420863916946436d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 133,
    Value = 
new System.Double[3]
{
0.2526924417451588d,
0.2197874617682971d,
0.13449046662899078d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4138686023459417d,
0.8473277854291421d,
0.028557214399820396d,
0.7386875953090379d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 138,
    Value = 
new System.Double[4]
{
0.5681576606096588d,
0.07598748814020662d,
0.05431611436710648d,
0.18923020218515152d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 62,
    Value = 
new System.Double[4]
{
0.8154297769945831d,
0.2770366875933703d,
0.23181600879606035d,
0.5816637015493558d,
},
    NullableValue = 
new System.Double[4]
{
0.7578221823485128d,
0.48895616698509214d,
0.5186249418441718d,
0.5539926097020499d,
},
},
    NullableValue = 
new System.Double[4]
{
0.7839031389410847d,
0.06347162200289724d,
0.4246983870151182d,
0.09357550398989178d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 145,
    Value = 
new System.Double[3]
{
0.7296934845779388d,
0.9103314323736019d,
0.6665151022736572d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 148,
    Value = 
new System.Double[3]
{
0.9483687817448557d,
0.12067989715540528d,
0.7440756394904814d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.03565950586528588d,
0.6809174877551654d,
0.2021496653654652d,
0.9523697829054089d,
},
    NullableValue = 
new System.Double[3]
{
0.5761241756705504d,
0.22382309751743223d,
0.2680930975917565d,
},
},
    NullableValue = 
new System.Double[4]
{
0.9702385918825567d,
0.8074281730940744d,
0.04196122070019104d,
0.8353896006142251d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 153,
    Value = 
new System.Double[3]
{
0.3613583611119554d,
0.5303740097869779d,
0.4416419441461322d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 154,
    Value = 
new System.Double[3]
{
0.22642763923274278d,
0.38027360454371983d,
0.47246873508130205d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 73,
    Value = 
new System.Double[4]
{
0.0016223260880283696d,
0.9674411594980821d,
0.5146255600831201d,
0.7972484935801066d,
},
    NullableValue = 
new System.Double[4]
{
0.7057029026544417d,
0.4263831428386119d,
0.4069735748693435d,
0.8283883524804003d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8438342709643906d,
0.7076179005681861d,
0.4891705763589541d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 160,
    Value = 
new System.Double[4]
{
0.20798581569162056d,
0.7480525365348234d,
0.20288752331555016d,
0.48762984129972387d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 164,
    Value = 
new System.Double[4]
{
0.7579573395833815d,
0.8278828510681684d,
0.6249084559856398d,
0.3643004440137929d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 82,
    Value = 
new System.Double[4]
{
0.39499184287793365d,
0.49340573778717367d,
0.282614828006696d,
0.2613630134734939d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.3208838524435855d,
0.5432489063178548d,
0.6404257943102825d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 171,
    Value = 
new System.Double[3]
{
0.5703698768962734d,
0.7151547866885463d,
0.598602195098404d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.7745747201486871d,
0.9757161899317206d,
0.8764374060925139d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 176,
    Value = 
new System.Double[3]
{
0.26914538041764646d,
0.5510878475273591d,
0.7337627099187063d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 90,
    Value = 
new System.Double[4]
{
0.6920112830828304d,
0.353992174782629d,
0.9050402557151069d,
0.43301516883487323d,
},
    NullableValue = 
new System.Double[3]
{
0.6962603183483461d,
0.986644086197925d,
0.38959048611317093d,
},
},
    NullableValue = 
new System.Double[3]
{
0.3983669201171821d,
0.7503271043532671d,
0.7357539435985919d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 180,
    Value = 
new System.Double[3]
{
0.48143337504586614d,
0.5298389705394564d,
0.44575753576695354d,
},
    ModelInner = null,
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.42979224837001617d,
0.7554975951592688d,
0.3134220285076318d,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.6360717014690606d,
0.8375935450649699d,
0.6807442796083972d,
}));
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
                Assert.That(nullable, Is.Null);
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
new System.Double[4]
{
0.2870871493289868d,
0.5046699440219514d,
0.4325627958480527d,
0.4215733466079844d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.9445042992295818d,
0.33226257160327255d,
0.2608729863742115d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.10838698104134903d,
0.8826031517073103d,
0.31506235330914933d,
}));
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.7599307284973448d,
0.5205594751743357d,
0.4256612245033894d,
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
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 67;
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
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 45, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 45, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 164, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 41, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[32],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 164, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[34], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 160);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
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

