

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
    internal partial interface IDecimalMArraynumericMMArrayD1
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD1 : IDecimalMArraynumericMMArrayD1
    {


#region TestData

        private readonly DecimalnumericMMArrayD1E1M[] _testData = new DecimalnumericMMArrayD1E1M[]
        {
            new DecimalnumericMMArrayD1E1M
{
    Id = 3,
    Value = 
new System.Decimal[4]
{
0.342037500466858m,
0.329783280312797m,
0.440903880118284m,
0.391028365247248m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 10,
    Value = 
new System.Decimal[4]
{
0.913971301119233m,
0.508128873053401m,
0.0340131631644308m,
0.139670291690642m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.448120186395081m,
0.994277274341243m,
0.39412159158214m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Decimal[4]
{
0.114985853269723m,
0.656108713979242m,
0.0702188393264526m,
0.501217780636652m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.73804078304358m,
0.666609764170366m,
0.330817849744669m,
0.0791071414509228m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Decimal[3]
{
0.779731536579141m,
0.551226497700259m,
0.965591069123358m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.312426452105946m,
0.0127902726353882m,
0.280972573025643m,
0.79774055659192m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.0681005267641716m,
0.509462723347056m,
0.257714832919661m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Decimal[4]
{
0.223880948848597m,
0.463104895001627m,
0.0423924549071228m,
0.631150068131604m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.704352232458645m,
0.152189650716746m,
0.0604974798696405m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.617165163776509m,
0.0240313125327654m,
0.839773571888424m,
0.115303394355927m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Decimal[4]
{
0.838859101724205m,
0.728625325158838m,
0.0403153160482054m,
0.378192324838795m,
},
    NullableValue = 
new System.Decimal[3]
{
0.669939378097246m,
0.234062725183137m,
0.445004512144533m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.295210428566172m,
0.374026424975505m,
0.103945737411943m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Decimal[4]
{
0.49655150066849m,
0.0504728809523422m,
0.710952973139982m,
0.225051431830297m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Decimal[4]
{
0.360577105758973m,
0.67249313420827m,
0.743576783608159m,
0.197890256484541m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.35793585544026m,
0.597076218910685m,
0.816660240348868m,
0.693426505247731m,
},
    NullableValue = 
new System.Decimal[4]
{
0.97917029549438m,
0.157330368107481m,
0.48707661365251m,
0.150242499101318m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.64720432503019m,
0.289218326618552m,
0.557608720187696m,
0.0525422422332119m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.976967187496656m,
0.100425351722145m,
0.208031800335521m,
0.0931023171135506m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0531081328818712m,
0.771179780620624m,
0.211362953676016m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.538580126961338m,
0.0721124267561588m,
0.859164885633201m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Decimal[3]
{
0.499835540365645m,
0.609990358069487m,
0.336875050235546m,
},
    NullableValue = 
new System.Decimal[3]
{
0.75193248666238m,
0.0140999014196557m,
0.921969028196766m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.209387643264767m,
0.0943078437782455m,
0.477908233466134m,
0.752051542762624m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Decimal[4]
{
0.519382526087393m,
0.786774520385452m,
0.885713006869724m,
0.0880652402032923m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Decimal[4]
{
0.550691586588467m,
0.998650105852594m,
0.211889985806449m,
0.0557689359038007m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.628704014753199m,
0.172553790900203m,
0.953752366788535m,
0.79238402108802m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Decimal[3]
{
0.500655547389171m,
0.585008450897272m,
0.184189690650713m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.422928526346122m,
0.122247090422281m,
0.362171015292918m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Decimal[4]
{
0.0867992084761914m,
0.121140756202279m,
0.850378672522718m,
0.958045122348088m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Decimal[4]
{
0.0172621597613594m,
0.247711574362589m,
0.145866261870185m,
0.615836099914732m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.263696112091464m,
0.6809279789538m,
0.48207760189622m,
0.557126121465996m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Decimal[3]
{
0.925094920261366m,
0.655360390432925m,
0.190768471149521m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Decimal[4]
{
0.170139282599847m,
0.677003355331893m,
0.427032198227751m,
0.0277063086339324m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.573849807999704m,
0.0915401422920321m,
0.711064514180509m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Decimal[3]
{
0.661535423540417m,
0.068695962096045m,
0.636496438640491m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.868740396486729m,
0.221711770563437m,
0.601122335456194m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Decimal[3]
{
0.0803142874663353m,
0.762288156096652m,
0.393119989846514m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Decimal[4]
{
0.482523092354856m,
0.433475321430583m,
0.424971109600073m,
0.583378081969905m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.82776188228439m,
0.577862398665601m,
0.453738071969481m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Decimal[3]
{
0.78095966521894m,
0.784538740485507m,
0.955058281199945m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.959075726763793m,
0.422881042311149m,
0.195144124110314m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Decimal[4]
{
0.635483545748216m,
0.344095499929724m,
0.706754753999928m,
0.915872325386869m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Decimal[3]
{
0.461586848116076m,
0.324387787520087m,
0.52956252032261m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.0163591256590778m,
0.194198304463111m,
0.781999354444106m,
0.200262007926358m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Decimal[4]
{
0.427544374387077m,
0.0423706447145127m,
0.0965382458339646m,
0.560174177395155m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Decimal[4]
{
0.623825183017581m,
0.621939954656608m,
0.476326969411522m,
0.681527938340692m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Decimal[3]
{
0.676573663911786m,
0.095549154685615m,
0.337491866451088m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Decimal[4]
{
0.744867587361159m,
0.710983111001199m,
0.42453073163767m,
0.837702621383514m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.11585741074266m,
0.866944250521476m,
0.57978022263894m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Decimal[3]
{
0.411365372704949m,
0.337141445544651m,
0.835207473000658m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Decimal[3]
{
0.101200774298012m,
0.47747144269285m,
0.613601823900222m,
},
    NullableValue = 
new System.Decimal[3]
{
0.591551156047899m,
0.786658885585614m,
0.17663483401426m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Decimal[4]
{
0.095689474896266m,
0.954532854039253m,
0.833465961146361m,
0.214109296694457m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.904344697173846m,
0.634065157538238m,
0.0874761503858396m,
0.970334074260986m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Decimal[4]
{
0.176677990041308m,
0.476520386930057m,
0.155345334500829m,
0.071321066289651m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.631653354316502m,
0.828182344420278m,
0.0429221506246097m,
0.0113086094576862m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Decimal[3]
{
0.756213217551385m,
0.794671052659017m,
0.894805083498396m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Decimal[4]
{
0.971853057159326m,
0.941877067283934m,
0.360309777399596m,
0.646943740432337m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Decimal[4]
{
0.106383743407546m,
0.463296261457296m,
0.0618813079369658m,
0.545401013815882m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.788502691013918m,
0.593449164058588m,
0.07135796313342m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Decimal[4]
{
0.204142910880032m,
0.705168335676568m,
0.0636131496793437m,
0.744055404803504m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.806085652874692m,
0.259609605361644m,
0.0483048708103344m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Decimal[3]
{
0.26318293369844m,
0.172972845589824m,
0.983110871483165m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Decimal[3]
{
0.497783013118962m,
0.587956688316704m,
0.660506904904839m,
},
    NullableValue = 
new System.Decimal[4]
{
0.319723809928851m,
0.747994035719355m,
0.691244132041661m,
0.920934455501172m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.472375642335352m,
0.121827235262273m,
0.273332185959331m,
0.0320915712388445m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Decimal[4]
{
0.918081414755206m,
0.891480725937174m,
0.238963589553716m,
0.216960182961881m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Decimal[3]
{
0.0351273062604938m,
0.69024444687754m,
0.704188349725793m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Decimal[4]
{
0.838805781330208m,
0.272326483796319m,
0.98369309542605m,
0.696880255393493m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.353445712343948m,
0.0525715195048948m,
0.935879905053446m,
0.197842241426373m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Decimal[3]
{
0.0493148750831833m,
0.0741239789635543m,
0.169645966043812m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Decimal[3]
{
0.376133740140693m,
0.931419375317764m,
0.7531957117742m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Decimal[4]
{
0.857544682824736m,
0.442528946192325m,
0.94448803474022m,
0.814293860226393m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0766688790190911m,
0.911174979137899m,
0.564196750939543m,
0.313774287745619m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Decimal[4]
{
0.740592612659044m,
0.480738170287166m,
0.787955574627088m,
0.736793504008748m,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.704352232458645m,
0.152189650716746m,
0.0604974798696405m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.295210428566172m,
0.374026424975505m,
0.103945737411943m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.64720432503019m,
0.289218326618552m,
0.557608720187696m,
0.0525422422332119m,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.0531081328818712m,
0.771179780620624m,
0.211362953676016m,
}));
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.209387643264767m,
0.0943078437782455m,
0.477908233466134m,
0.752051542762624m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr2.Value = 79;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 79, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 94, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 42, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 154, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 49, 3))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
FROM public.binary_decimalnumericmmarrayd1e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI), typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

