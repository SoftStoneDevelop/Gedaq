

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
    Id = 2,
    Value = 
new System.Double[3]
{
0.91532699128659d,
0.13401742270499417d,
0.893771275543539d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8913937958572238d,
0.684636354912871d,
0.2162570223018283d,
0.9910694845753822d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 5,
    Value = 
new System.Double[4]
{
0.28945420788909104d,
0.19447961123547364d,
0.7948363036890456d,
0.5964116169295217d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 4,
    Value = 
new System.Double[4]
{
0.8234085205567108d,
0.597527311842603d,
0.14398155925755862d,
0.34817779946326843d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5653316053471255d,
0.38609796646685957d,
0.735204899287779d,
0.9155688648057506d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 7,
    Value = 
new System.Double[3]
{
0.51136929755472d,
0.2774260936352112d,
0.33052830316023274d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.6379499967004955d,
0.26141550202321595d,
0.6679801033915317d,
0.6289819161024884d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 12,
    Value = 
new System.Double[3]
{
0.2465814879561422d,
0.17684600579751575d,
0.04321067730705386d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[3]
{
0.9638258095927144d,
0.9961794323593712d,
0.2661083745612275d,
},
    NullableValue = 
new System.Double[3]
{
0.5547909277697433d,
0.556103737359226d,
0.29542366839620315d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 19,
    Value = 
new System.Double[3]
{
0.016456768633087093d,
0.5683763920657889d,
0.640310109404592d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 26,
    Value = 
new System.Double[3]
{
0.4991819860196627d,
0.11091512311404739d,
0.45743850144260356d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 13,
    Value = 
new System.Double[3]
{
0.41008332231361755d,
0.3870207233075518d,
0.7010110738493285d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 35,
    Value = 
new System.Double[3]
{
0.7345374781211621d,
0.2272022259973474d,
0.57931992932923d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.44778005637536167d,
0.19249557939758433d,
0.876026276763837d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 39,
    Value = 
new System.Double[4]
{
0.9149778304074249d,
0.29490727006518214d,
0.9971078292975872d,
0.3853646002413871d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 17,
    Value = 
new System.Double[3]
{
0.3620515139718876d,
0.06330119440217774d,
0.7066672077507844d,
},
    NullableValue = 
new System.Double[4]
{
0.8615144134804763d,
0.6471105544707232d,
0.29677249340009404d,
0.6593819115039247d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 45,
    Value = 
new System.Double[3]
{
0.3517630780390639d,
0.07586117126230363d,
0.19348344836403086d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 49,
    Value = 
new System.Double[4]
{
0.11617764440009026d,
0.121501959570124d,
0.7764331716725196d,
0.24881720220146852d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 26,
    Value = 
new System.Double[4]
{
0.2589265324011145d,
0.29157251085925406d,
0.3688817846590915d,
0.9353954562712185d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.6012496637601408d,
0.5700801612428984d,
0.2967202410294051d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.5067429260032705d,
0.371225875846089d,
0.20002056387065315d,
0.06550563703996248d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5639860049465744d,
0.8112923100757329d,
0.6845224062465243d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 63,
    Value = 
new System.Double[4]
{
0.9529066812187819d,
0.8449164846696506d,
0.7214575705875282d,
0.2956233156709773d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.08835109907787597d,
0.3882670279043502d,
0.3801814608193754d,
},
    NullableValue = 
new System.Double[3]
{
0.8125360288966649d,
0.32940116549645937d,
0.8609100625883328d,
},
},
    NullableValue = 
new System.Double[3]
{
0.19049707933932192d,
0.5440648676966262d,
0.39611494025616567d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.4985697680435386d,
0.04621279741289064d,
0.1854013004819698d,
0.9841918739678962d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.10098028063336628d,
0.5639980792670224d,
0.20685049096844454d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.8372598309143648d,
0.35069728686488644d,
0.12271336338204286d,
0.08202562178872996d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[4]
{
0.5032011970758092d,
0.8976404266041053d,
0.08078212349816993d,
0.5933576176163026d,
},
    NullableValue = 
new System.Double[4]
{
0.263131732392334d,
0.514169061840591d,
0.9850753960488089d,
0.3199336922643189d,
},
},
    NullableValue = 
new System.Double[4]
{
0.23827500207190266d,
0.22255708727863277d,
0.21494842162272743d,
0.015251371982637374d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 70,
    Value = 
new System.Double[3]
{
0.15861242048350044d,
0.6731224625858152d,
0.26363651881201045d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 78,
    Value = 
new System.Double[3]
{
0.3673678974361455d,
0.8429245405124313d,
0.4215053422820316d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 44,
    Value = 
new System.Double[3]
{
0.08588391845581322d,
0.8254142486478887d,
0.6604807773709648d,
},
    NullableValue = 
new System.Double[3]
{
0.8464291866359264d,
0.7183694234342051d,
0.42456350338101456d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 79,
    Value = 
new System.Double[3]
{
0.5820817570992461d,
0.387449309113005d,
0.14979138270075953d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.1575450746942364d,
0.8067936457093603d,
0.33344747142194764d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 87,
    Value = 
new System.Double[3]
{
0.7135842716812578d,
0.6460619417058402d,
0.5431532250414495d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.9042880594019106d,
0.9015640342620035d,
0.6795079103274232d,
},
    NullableValue = 
new System.Double[3]
{
0.6843456040294805d,
0.45832215521142916d,
0.7869904173028729d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 92,
    Value = 
new System.Double[4]
{
0.12897657062116108d,
0.5852481937012324d,
0.8256718309331185d,
0.6524685156629043d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7784004312254972d,
0.6628044178181152d,
0.35699112905692565d,
0.1408271144195784d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 100,
    Value = 
new System.Double[4]
{
0.8926542973506484d,
0.7616760232179515d,
0.2787376949070449d,
0.771628580630483d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 51,
    Value = 
new System.Double[3]
{
0.30026890659912087d,
0.8601581002038801d,
0.753233673244285d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 103,
    Value = 
new System.Double[4]
{
0.8751568686591779d,
0.006487667406065878d,
0.957760035294239d,
0.587993093698623d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 110,
    Value = 
new System.Double[3]
{
0.8597037015562453d,
0.8474440262718983d,
0.8873441788376075d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 54,
    Value = 
new System.Double[3]
{
0.22943097140009483d,
0.896330695562469d,
0.03920567086470761d,
},
    NullableValue = 
new System.Double[4]
{
0.9955644894780357d,
0.24296467070527195d,
0.564821274546541d,
0.552818037572031d,
},
},
    NullableValue = 
new System.Double[4]
{
0.6949937153405634d,
0.3177289397188173d,
0.6995062410677461d,
0.7014944217224216d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 114,
    Value = 
new System.Double[3]
{
0.5550854203555182d,
0.6680674808579126d,
0.6037254385295685d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 120,
    Value = 
new System.Double[4]
{
0.907064100250819d,
0.06558134904920465d,
0.3750577817394759d,
0.6686494684284747d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.2561394728529308d,
0.23639287243722895d,
0.8282002770488982d,
0.6321205907116683d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 122,
    Value = 
new System.Double[4]
{
0.2082993270244562d,
0.16374197777034238d,
0.08102420296773638d,
0.969624313597142d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 123,
    Value = 
new System.Double[3]
{
0.5321441128685612d,
0.9697882606050322d,
0.07785688808552693d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.4772668253215755d,
0.161097840727767d,
0.9164623686970823d,
0.6376176074098159d,
},
    NullableValue = 
new System.Double[3]
{
0.7265518078665814d,
0.26405175264008796d,
0.7635472095217453d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 126,
    Value = 
new System.Double[3]
{
0.645803497533921d,
0.13107491590758313d,
0.8841951380313349d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9930171478214043d,
0.061365936070350346d,
0.5511161445615667d,
0.9022645670946186d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 129,
    Value = 
new System.Double[4]
{
0.6861081943739813d,
0.3445583334373554d,
0.6724890017049049d,
0.3731073217493346d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 72,
    Value = 
new System.Double[4]
{
0.9596950771181697d,
0.8666600359021418d,
0.019430661314296716d,
0.8754285290120578d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.9166857012376497d,
0.6557768503881957d,
0.9996946985531402d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 137,
    Value = 
new System.Double[3]
{
0.3299604958081762d,
0.9906237158470206d,
0.25321102307985566d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.11686596148234529d,
0.7148085578220503d,
0.31475612910489537d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 146,
    Value = 
new System.Double[3]
{
0.06766478984255397d,
0.035158972653623444d,
0.6056883029871353d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.21223703274935202d,
0.10797061200414537d,
0.2554623325537603d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.44778005637536167d,
0.19249557939758433d,
0.876026276763837d,
}));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.6012496637601408d,
0.5700801612428984d,
0.2967202410294051d,
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
0.5639860049465744d,
0.8112923100757329d,
0.6845224062465243d,
}));
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.19049707933932192d,
0.5440648676966262d,
0.39611494025616567d,
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
                parametr1.Value = 5;
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
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[29], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 129, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[29], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[29], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 92, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[29], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 78, 92))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 69, 2))
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
                        Assert.That(models, Has.Count.EqualTo(29));

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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(8));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
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
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
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
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

