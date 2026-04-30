

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.917069591076476m,

0.353023460115214m,

0.680678860315041m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.759212203787832m,

0.0351294731599876m,

0.295104129392233m,

0.947833128419495m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.485704233008196m,

0.196760030628558m,

0.308839346704327m,

0.181010502072351m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.750920615670964m,

0.828561588634105m,

0.329168938426193m,

0.625477756855026m,

},
},
            new DecimalnumericArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0134327986096998m,

0.140615220329544m,

0.852315419088792m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.715263317021758m,

0.318925884804765m,

0.240086022549774m,

0.0356001032199887m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.705594550213226m,

0.188750871698727m,

0.0301889140577744m,

0.190208445739722m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.12284888228986m,

0.888258528981983m,

0.622730969839029m,

},
},
            new DecimalnumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63439637377588m,

0.58666256428915m,

0.548452026800302m,

0.756100660361334m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.279383908016271m,

0.632128250866196m,

0.238106430811606m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.796783682218715m,

0.354677230035202m,

0.111535715071327m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.190956615721326m,

0.165542263368968m,

0.987063442036004m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.820302153867797m,

0.176914439572405m,

0.243312574002684m,

0.688005845242494m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0629091772476613m,

0.478471881130477m,

0.513424967158113m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.759226494158654m,

0.119077884866446m,

0.4649684878473m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.153933720274097m,

0.80666614735491m,

0.456709401054314m,

},
},
            new DecimalnumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.953199562766788m,

0.419756785426216m,

0.761064829643873m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.504521614585876m,

0.452776656367949m,

0.151014205228656m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0897929603276724m,

0.0754451826867606m,

0.264259485485277m,

0.650230308545151m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.816667619461325m,

0.737869416794049m,

0.204465331777343m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.414934062537902m,

0.455943721357088m,

0.651385868089757m,

},
},
            new DecimalnumericArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.360334180651027m,

0.068993086289304m,

0.323928750536043m,

0.748219275652623m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.325462206072209m,

0.402743253625736m,

0.936888799257929m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.638841945328662m,

0.972842969115643m,

0.475176651789623m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0410843364764984m,

0.297809678948416m,

0.877917798504126m,

0.955453319092626m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.961505813925852m,

0.620919255611281m,

0.18853512635129m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.881007890167819m,

0.585083419625053m,

0.303936069101598m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.430269551646382m,

0.417390699909097m,

0.512929477879958m,

0.513855633167199m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.711919242149925m,

0.367167971725416m,

0.957886966107811m,

0.938322964154688m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.28397026218868m,

0.456747145356465m,

0.577593172198984m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.672173626112945m,

0.842229467630704m,

0.658303777517573m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.032108021277273m,

0.723222796247293m,

0.774525878351849m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.818288980341986m,

0.807823777553935m,

0.779019995229322m,

},
},
            new DecimalnumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0680597333242116m,

0.753944779493462m,

0.173843678849713m,

0.581476795684166m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0695705217920827m,

0.957608079465815m,

0.0352255325788256m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0435315641177831m,

0.951288462304224m,

0.855492709310665m,

0.850779548405665m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.119978817121595m,

0.203931757992099m,

0.128978076182025m,

0.0197612460098501m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.652073090377825m,

0.504903790592941m,

0.545143747881711m,

},
},
            new DecimalnumericArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.125602134399639m,

0.182071716251092m,

0.678372826688386m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74609192036997m,

0.489282678191614m,

0.569816901464971m,

0.76287127131124m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.237367242693475m,

0.11205681433357m,

0.0374665240622801m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.207046392454495m,

0.668946581383198m,

0.915129540270402m,

0.965554484576934m,

},
},
            new DecimalnumericArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.655669328863903m,

0.820292112409248m,

0.232996576953526m,

0.0314204489208108m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.313595823109526m,

0.72867649449881m,

0.793158374696238m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.621193059543376m,

0.60484954228043m,

0.614013963661802m,

0.300402852473047m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.115924440661315m,

0.417352813000031m,

0.878652977881842m,

0.161456394847481m,

},
},
            new DecimalnumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0522537663436676m,

0.0349138702705285m,

0.834330784271691m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.33252727687131m,

0.232324889971397m,

0.925383413741124m,

},
},
            new DecimalnumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0539396965447323m,

0.088325156355113m,

0.676240062961889m,

0.949335272568023m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.80032284961905m,

0.331626782915089m,

0.385879736908954m,

0.476613171931997m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0768646944204345m,

0.822940377004505m,

0.867211016734217m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.666135839328266m,

0.320551335972004m,

0.0851448506121081m,

},
},
            new DecimalnumericArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.526273733687746m,

0.096358832585127m,

0.840535856372403m,

0.465942956481081m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.730618194934388m,

0.154439880000519m,

0.249334047971203m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.499722378580469m,

0.515212340779131m,

0.84345185924075m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.970586664974415m,

0.654051959514216m,

0.609188969727834m,

0.707608097572232m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.788889541704756m,

0.690680510044121m,

0.434309135013089m,

0.517252627062984m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.680562492661079m,

0.996552623592803m,

0.559390830393597m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.35964874675363m,

0.587928639792633m,

0.50723912295932m,

0.817024944223677m,

},
},
            new DecimalnumericArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.668998128663849m,

0.636971274955959m,

0.659401687757502m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.484866274328977m,

0.277879527551769m,

0.43405807655534m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.562099626832609m,

0.467713142084277m,

0.654939520703483m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.586293848302204m,

0.227665509528876m,

0.776415881198876m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.832239517823985m,

0.52155614940249m,

0.884927076562774m,

0.827418187614441m,

},
},
            new DecimalnumericArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.167020815184369m,

0.0774297201603898m,

0.923411700757191m,

0.897872804675865m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.862935061612408m,

0.167302649006479m,

0.749020493067336m,

0.39693478433571m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.104861222703964m,

0.651494469840054m,

0.179517811655895m,

0.492984004591939m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72050864863936m,

0.494240038693536m,

0.785728332555199m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623513950738616m,

0.429220949143362m,

0.24667667439464m,

0.707074751333913m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.38379118980025m,

0.726775466793444m,

0.220043523463272m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.332747094922392m,

0.780000142205088m,

0.671006173276842m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.886116852790774m,

0.992492855361333m,

0.0829908810986364m,

0.702403822192961m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 71;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 6, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 134, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 108, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 97, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 2, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 81, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 153, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 159, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
DecimalnumericArray2M.AssertModel(models[0],_testData[15], false);DecimalnumericArray2M.AssertModel(models[1],_testData[16], false);DecimalnumericArray2M.AssertModel(models[2],_testData[17], false);DecimalnumericArray2M.AssertModel(models[3],_testData[18], false);DecimalnumericArray2M.AssertModel(models[4],_testData[19], false);DecimalnumericArray2M.AssertModel(models[5],_testData[20], false);DecimalnumericArray2M.AssertModel(models[6],_testData[21], false);DecimalnumericArray2M.AssertModel(models[7],_testData[22], false);DecimalnumericArray2M.AssertModel(models[8],_testData[23], false);DecimalnumericArray2M.AssertModel(models[9],_testData[24], false);DecimalnumericArray2M.AssertModel(models[10],_testData[25], false);DecimalnumericArray2M.AssertModel(models[11],_testData[26], false);DecimalnumericArray2M.AssertModel(models[12],_testData[27], false);DecimalnumericArray2M.AssertModel(models[13],_testData[28], false);DecimalnumericArray2M.AssertModel(models[14],_testData[29], false);DecimalnumericArray2M.AssertModel(models[15],_testData[30], false);DecimalnumericArray2M.AssertModel(models[16],_testData[31], false);DecimalnumericArray2M.AssertModel(models[17],_testData[32], false);DecimalnumericArray2M.AssertModel(models[18],_testData[33], false);DecimalnumericArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
DecimalnumericArray2M.AssertModel(models[0],_testData[31], false);DecimalnumericArray2M.AssertModel(models[1],_testData[32], false);DecimalnumericArray2M.AssertModel(models[2],_testData[33], false);DecimalnumericArray2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models = await ((IDecimalListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI), typeof(DecimalnumericArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                await ((IDecimalListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                ((IDecimalListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

