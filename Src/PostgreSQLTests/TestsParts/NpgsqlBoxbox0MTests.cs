

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47539350471613284d,right: 0.949113892109604d,bottom: 0.3690346475693205d,left: 0.5898960307595267d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9980548302038784d,right: 0.23311177781384285d,bottom: 0.6340893011580006d,left: 0.1581341249487057d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6850841826448354d,right: 0.6973188463008678d,bottom: 0.0545398966337437d,left: 0.19502521212952928d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.22330724315654915d,right: 0.9785654122542161d,bottom: 0.04279499638929618d,left: 0.7473145973855407d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3293872527837184d,right: 0.41518207379716043d,bottom: 0.22243196515687458d,left: 0.30358406002407945d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6621110136723631d,right: 0.6868571734603798d,bottom: 0.10155148939507985d,left: 0.11659611533573366d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8139259293874157d,right: 0.7091046504722718d,bottom: 0.14911247975105424d,left: 0.413146002025248d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9445765921649646d,right: 0.5178417102109605d,bottom: 0.8679967690492992d,left: 0.37592781674455544d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5596437288190125d,right: 0.9769161042169792d,bottom: 0.5295455809616385d,left: 0.12347009695526812d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3103749907977209d,right: 0.8004506739981175d,bottom: 0.2656375500944933d,left: 0.33524597253466437d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9783589782525164d,right: 0.9704955806122976d,bottom: 0.15430639552531344d,left: 0.3489735680208861d),
},
            new NpgsqlBoxbox0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.15466618328088666d,right: 0.764055145642897d,bottom: 0.057631926779321385d,left: 0.43827383782233487d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.04150566246437981d,right: 0.960330251843534d,bottom: 0.0007313164396643979d,left: 0.5813334752328486d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5884709019529608d,right: 0.6628760587057846d,bottom: 0.21268074034713114d,left: 0.34507268765337984d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7295801579933555d,right: 0.9147031533626193d,bottom: 0.5530579777885539d,left: 0.2627728687947981d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.899870083529353d,right: 0.7997265907127866d,bottom: 0.5681157970475205d,left: 0.7456175597430708d),
},
            new NpgsqlBoxbox0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2540500697076703d,right: 0.7387987679723476d,bottom: 0.007274208652557901d,left: 0.041241495669256945d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.909828653264084d,right: 0.9628109141487163d,bottom: 0.7032465316289982d,left: 0.5456536096502892d),
},
            new NpgsqlBoxbox0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5923187322373912d,right: 0.9587837890127198d,bottom: 0.22989245945824943d,left: 0.4541031300612608d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8409090853219305d,right: 0.5895205767789704d,bottom: 0.444162050969535d,left: 0.08371978299357208d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49029596627980054d,right: 0.6334304694773065d,bottom: 0.042821958086526446d,left: 0.06316422012698264d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4237649189517506d,right: 0.9229807352630569d,bottom: 0.07166728469437755d,left: 0.1963815693329054d),
},
            new NpgsqlBoxbox0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.10115880824734091d,right: 0.45923773570788895d,bottom: 0.03791051230328524d,left: 0.293386432381851d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5317475067860602d,right: 0.7451371073812809d,bottom: 0.5115513457588382d,left: 0.02050152090541435d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5377643174904803d,right: 0.7807219342923609d,bottom: 0.11014180016285102d,left: 0.07057332677093942d),
},
            new NpgsqlBoxbox0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.42254364773862463d,right: 0.14051356443281215d,bottom: 0.3081967226975001d,left: 0.08036129540468107d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.26891118737289443d,right: 0.8946424162554033d,bottom: 0.25850988248327733d,left: 0.8172795116301138d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8953985692144784d,right: 0.9243840133848532d,bottom: 0.7341973413834064d,left: 0.6784614501034175d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.19413775362553976d,right: 0.5853181626309525d,bottom: 0.15240536592889864d,left: 0.11610046131222351d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6113901043123533d,right: 0.5264700254541466d,bottom: 0.08315803739883432d,left: 0.08822290044708869d),
},
            new NpgsqlBoxbox0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.44655846651311515d,right: 0.8375542939531638d,bottom: 0.36256199023677527d,left: 0.8176780796387122d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4307970844486284d,right: 0.7669156291061707d,bottom: 0.05932833787274905d,left: 0.5184185630978221d),
},
            new NpgsqlBoxbox0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7890325393744158d,right: 0.45484825161848397d,bottom: 0.4248332454373559d,left: 0.3530420168885222d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9920318823411917d,right: 0.5591703244322541d,bottom: 0.6745066878166053d,left: 0.49715502088881014d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4326025855935888d,right: 0.7839107673555836d,bottom: 0.02839424414930125d,left: 0.12044011904237861d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9050983178241256d,right: 0.7247775286082052d,bottom: 0.27545913464748295d,left: 0.5109932584567212d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.30887685648018226d,right: 0.7130798591287955d,bottom: 0.022721271769956863d,left: 0.3575978861852478d),
},
            new NpgsqlBoxbox0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9791652425176568d,right: 0.16825632915024114d,bottom: 0.09255800081637866d,left: 0.15731071001934027d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.52990107609638d,right: 0.6170287750475821d,bottom: 0.0490107561027352d,left: 0.018889625162835655d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.14978792473015023d,right: 0.9452046113182304d,bottom: 0.09743866171398363d,left: 0.7704347089528585d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.49507389180074124d,right: 0.9700438211692511d,bottom: 0.07177150472266369d,left: 0.23104758545826842d),
},
            new NpgsqlBoxbox0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5179196320800077d,right: 0.2299596844038152d,bottom: 0.00363722315571835d,left: 0.0032611562846657227d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9975597527370532d,right: 0.6688438185804247d,bottom: 0.6072043289008177d,left: 0.19743970383195375d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3842364035747696d,right: 0.9847725522543984d,bottom: 0.00031575477423551046d,left: 0.36034531959807203d),
},
            new NpgsqlBoxbox0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.395685493338775d,right: 0.7889512851200176d,bottom: 0.20033440176314832d,left: 0.29284804743225634d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5791843089276495d,right: 0.8258152872389942d,bottom: 0.3433156739794049d,left: 0.047867763982201494d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17522794357992133d,right: 0.023675191926769923d,bottom: 0.0660493648227245d,left: 0.02073887485401571d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8448181175311801d,right: 0.5780185728635934d,bottom: 0.12415729112671137d,left: 0.17054371881617014d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.11575827570260877d,right: 0.6397530911658819d,bottom: 0.051866750389991556d,left: 0.485020365604912d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7687849341560377d,right: 0.1986373976515231d,bottom: 0.3397133610487556d,left: 0.19332124855527455d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6309207454130791d,right: 0.47717793015527876d,bottom: 0.3744762807062584d,left: 0.253994446731003d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.21155412177486455d,right: 0.9640947977198339d,bottom: 0.013097890264459067d,left: 0.1874558167885102d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.262228953493982d,right: 0.5603051039045361d,bottom: 0.24785580165986154d,left: 0.22340771608599552d),
},
            new NpgsqlBoxbox0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9152843126606096d,right: 0.9304478861223262d,bottom: 0.7167120470559001d,left: 0.7671343100758664d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8345746661675184d,right: 0.17852833604610685d,bottom: 0.8329953839456106d,left: 0.14985866325770092d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.1481277000500938d,right: 0.6442513960098213d,bottom: 0.014832803796036798d,left: 0.4283295521919347d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8995966019478849d,right: 0.9741100605146127d,bottom: 0.6389252530090723d,left: 0.6169171531385154d),
},
            new NpgsqlBoxbox0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.20354952986591068d,right: 0.9764105525778052d,bottom: 0.09468444415863975d,left: 0.35076967733131625d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.454867838645598d,right: 0.8563566643556342d,bottom: 0.2832789464291886d,left: 0.03328947797052306d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49673243897221386d,right: 0.7373156537623762d,bottom: 0.19596899693675263d,left: 0.08256898762303744d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9637745233169213d,right: 0.6663347734620519d,bottom: 0.5849133256413999d,left: 0.43974726884026527d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6684188362128296d,right: 0.8911499817902547d,bottom: 0.12190384430935552d,left: 0.5426604406363381d),
},
            new NpgsqlBoxbox0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8647509531782981d,right: 0.5941521504641015d,bottom: 0.7959778599200931d,left: 0.21380790041007003d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.19557011667113777d,right: 0.7174403088995596d,bottom: 0.13771128066437666d,left: 0.44682133770519183d),
},
            new NpgsqlBoxbox0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.60373090620908d,right: 0.18184578667596796d,bottom: 0.40873213594104474d,left: 0.15975788744039854d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47801462708986675d,right: 0.2774956551506941d,bottom: 0.3436951864297577d,left: 0.04808924898118416d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.640197462761732d,right: 0.553399029737956d,bottom: 0.47226649137519805d,left: 0.3012314652303819d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6701341349239132d,right: 0.5470972566890142d,bottom: 0.4878921302758056d,left: 0.45045398415529625d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9783589782525164d,right: 0.9704955806122976d,bottom: 0.15430639552531344d,left: 0.3489735680208861d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.899870083529353d,right: 0.7997265907127866d,bottom: 0.5681157970475205d,left: 0.7456175597430708d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.909828653264084d,right: 0.9628109141487163d,bottom: 0.7032465316289982d,left: 0.5456536096502892d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4237649189517506d,right: 0.9229807352630569d,bottom: 0.07166728469437755d,left: 0.1963815693329054d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5377643174904803d,right: 0.7807219342923609d,bottom: 0.11014180016285102d,left: 0.07057332677093942d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 66, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 118, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 126, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 39, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 74, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[29], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 87, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47539350471613284d,right: 0.949113892109604d,bottom: 0.3690346475693205d,left: 0.5898960307595267d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9980548302038784d,right: 0.23311177781384285d,bottom: 0.6340893011580006d,left: 0.1581341249487057d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6850841826448354d,right: 0.6973188463008678d,bottom: 0.0545398966337437d,left: 0.19502521212952928d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22330724315654915d,right: 0.9785654122542161d,bottom: 0.04279499638929618d,left: 0.7473145973855407d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3293872527837184d,right: 0.41518207379716043d,bottom: 0.22243196515687458d,left: 0.30358406002407945d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6621110136723631d,right: 0.6868571734603798d,bottom: 0.10155148939507985d,left: 0.11659611533573366d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8139259293874157d,right: 0.7091046504722718d,bottom: 0.14911247975105424d,left: 0.413146002025248d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9445765921649646d,right: 0.5178417102109605d,bottom: 0.8679967690492992d,left: 0.37592781674455544d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5596437288190125d,right: 0.9769161042169792d,bottom: 0.5295455809616385d,left: 0.12347009695526812d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3103749907977209d,right: 0.8004506739981175d,bottom: 0.2656375500944933d,left: 0.33524597253466437d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9783589782525164d,right: 0.9704955806122976d,bottom: 0.15430639552531344d,left: 0.3489735680208861d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.15466618328088666d,right: 0.764055145642897d,bottom: 0.057631926779321385d,left: 0.43827383782233487d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.04150566246437981d,right: 0.960330251843534d,bottom: 0.0007313164396643979d,left: 0.5813334752328486d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5884709019529608d,right: 0.6628760587057846d,bottom: 0.21268074034713114d,left: 0.34507268765337984d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7295801579933555d,right: 0.9147031533626193d,bottom: 0.5530579777885539d,left: 0.2627728687947981d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.899870083529353d,right: 0.7997265907127866d,bottom: 0.5681157970475205d,left: 0.7456175597430708d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2540500697076703d,right: 0.7387987679723476d,bottom: 0.007274208652557901d,left: 0.041241495669256945d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.909828653264084d,right: 0.9628109141487163d,bottom: 0.7032465316289982d,left: 0.5456536096502892d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5923187322373912d,right: 0.9587837890127198d,bottom: 0.22989245945824943d,left: 0.4541031300612608d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8409090853219305d,right: 0.5895205767789704d,bottom: 0.444162050969535d,left: 0.08371978299357208d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49029596627980054d,right: 0.6334304694773065d,bottom: 0.042821958086526446d,left: 0.06316422012698264d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4237649189517506d,right: 0.9229807352630569d,bottom: 0.07166728469437755d,left: 0.1963815693329054d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.10115880824734091d,right: 0.45923773570788895d,bottom: 0.03791051230328524d,left: 0.293386432381851d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5317475067860602d,right: 0.7451371073812809d,bottom: 0.5115513457588382d,left: 0.02050152090541435d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5377643174904803d,right: 0.7807219342923609d,bottom: 0.11014180016285102d,left: 0.07057332677093942d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42254364773862463d,right: 0.14051356443281215d,bottom: 0.3081967226975001d,left: 0.08036129540468107d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.26891118737289443d,right: 0.8946424162554033d,bottom: 0.25850988248327733d,left: 0.8172795116301138d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8953985692144784d,right: 0.9243840133848532d,bottom: 0.7341973413834064d,left: 0.6784614501034175d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19413775362553976d,right: 0.5853181626309525d,bottom: 0.15240536592889864d,left: 0.11610046131222351d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6113901043123533d,right: 0.5264700254541466d,bottom: 0.08315803739883432d,left: 0.08822290044708869d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44655846651311515d,right: 0.8375542939531638d,bottom: 0.36256199023677527d,left: 0.8176780796387122d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4307970844486284d,right: 0.7669156291061707d,bottom: 0.05932833787274905d,left: 0.5184185630978221d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7890325393744158d,right: 0.45484825161848397d,bottom: 0.4248332454373559d,left: 0.3530420168885222d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9920318823411917d,right: 0.5591703244322541d,bottom: 0.6745066878166053d,left: 0.49715502088881014d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4326025855935888d,right: 0.7839107673555836d,bottom: 0.02839424414930125d,left: 0.12044011904237861d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9050983178241256d,right: 0.7247775286082052d,bottom: 0.27545913464748295d,left: 0.5109932584567212d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30887685648018226d,right: 0.7130798591287955d,bottom: 0.022721271769956863d,left: 0.3575978861852478d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9791652425176568d,right: 0.16825632915024114d,bottom: 0.09255800081637866d,left: 0.15731071001934027d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.52990107609638d,right: 0.6170287750475821d,bottom: 0.0490107561027352d,left: 0.018889625162835655d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14978792473015023d,right: 0.9452046113182304d,bottom: 0.09743866171398363d,left: 0.7704347089528585d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49507389180074124d,right: 0.9700438211692511d,bottom: 0.07177150472266369d,left: 0.23104758545826842d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5179196320800077d,right: 0.2299596844038152d,bottom: 0.00363722315571835d,left: 0.0032611562846657227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9975597527370532d,right: 0.6688438185804247d,bottom: 0.6072043289008177d,left: 0.19743970383195375d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3842364035747696d,right: 0.9847725522543984d,bottom: 0.00031575477423551046d,left: 0.36034531959807203d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.395685493338775d,right: 0.7889512851200176d,bottom: 0.20033440176314832d,left: 0.29284804743225634d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5791843089276495d,right: 0.8258152872389942d,bottom: 0.3433156739794049d,left: 0.047867763982201494d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17522794357992133d,right: 0.023675191926769923d,bottom: 0.0660493648227245d,left: 0.02073887485401571d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8448181175311801d,right: 0.5780185728635934d,bottom: 0.12415729112671137d,left: 0.17054371881617014d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.11575827570260877d,right: 0.6397530911658819d,bottom: 0.051866750389991556d,left: 0.485020365604912d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7687849341560377d,right: 0.1986373976515231d,bottom: 0.3397133610487556d,left: 0.19332124855527455d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6309207454130791d,right: 0.47717793015527876d,bottom: 0.3744762807062584d,left: 0.253994446731003d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21155412177486455d,right: 0.9640947977198339d,bottom: 0.013097890264459067d,left: 0.1874558167885102d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.262228953493982d,right: 0.5603051039045361d,bottom: 0.24785580165986154d,left: 0.22340771608599552d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9152843126606096d,right: 0.9304478861223262d,bottom: 0.7167120470559001d,left: 0.7671343100758664d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8345746661675184d,right: 0.17852833604610685d,bottom: 0.8329953839456106d,left: 0.14985866325770092d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1481277000500938d,right: 0.6442513960098213d,bottom: 0.014832803796036798d,left: 0.4283295521919347d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8995966019478849d,right: 0.9741100605146127d,bottom: 0.6389252530090723d,left: 0.6169171531385154d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.20354952986591068d,right: 0.9764105525778052d,bottom: 0.09468444415863975d,left: 0.35076967733131625d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.454867838645598d,right: 0.8563566643556342d,bottom: 0.2832789464291886d,left: 0.03328947797052306d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49673243897221386d,right: 0.7373156537623762d,bottom: 0.19596899693675263d,left: 0.08256898762303744d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9637745233169213d,right: 0.6663347734620519d,bottom: 0.5849133256413999d,left: 0.43974726884026527d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6684188362128296d,right: 0.8911499817902547d,bottom: 0.12190384430935552d,left: 0.5426604406363381d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8647509531782981d,right: 0.5941521504641015d,bottom: 0.7959778599200931d,left: 0.21380790041007003d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19557011667113777d,right: 0.7174403088995596d,bottom: 0.13771128066437666d,left: 0.44682133770519183d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.60373090620908d,right: 0.18184578667596796d,bottom: 0.40873213594104474d,left: 0.15975788744039854d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47801462708986675d,right: 0.2774956551506941d,bottom: 0.3436951864297577d,left: 0.04808924898118416d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.640197462761732d,right: 0.553399029737956d,bottom: 0.47226649137519805d,left: 0.3012314652303819d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6701341349239132d,right: 0.5470972566890142d,bottom: 0.4878921302758056d,left: 0.45045398415529625d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47539350471613284d,right: 0.949113892109604d,bottom: 0.3690346475693205d,left: 0.5898960307595267d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9980548302038784d,right: 0.23311177781384285d,bottom: 0.6340893011580006d,left: 0.1581341249487057d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6850841826448354d,right: 0.6973188463008678d,bottom: 0.0545398966337437d,left: 0.19502521212952928d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22330724315654915d,right: 0.9785654122542161d,bottom: 0.04279499638929618d,left: 0.7473145973855407d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3293872527837184d,right: 0.41518207379716043d,bottom: 0.22243196515687458d,left: 0.30358406002407945d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6621110136723631d,right: 0.6868571734603798d,bottom: 0.10155148939507985d,left: 0.11659611533573366d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8139259293874157d,right: 0.7091046504722718d,bottom: 0.14911247975105424d,left: 0.413146002025248d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9445765921649646d,right: 0.5178417102109605d,bottom: 0.8679967690492992d,left: 0.37592781674455544d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5596437288190125d,right: 0.9769161042169792d,bottom: 0.5295455809616385d,left: 0.12347009695526812d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3103749907977209d,right: 0.8004506739981175d,bottom: 0.2656375500944933d,left: 0.33524597253466437d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9783589782525164d,right: 0.9704955806122976d,bottom: 0.15430639552531344d,left: 0.3489735680208861d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.15466618328088666d,right: 0.764055145642897d,bottom: 0.057631926779321385d,left: 0.43827383782233487d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.04150566246437981d,right: 0.960330251843534d,bottom: 0.0007313164396643979d,left: 0.5813334752328486d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5884709019529608d,right: 0.6628760587057846d,bottom: 0.21268074034713114d,left: 0.34507268765337984d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7295801579933555d,right: 0.9147031533626193d,bottom: 0.5530579777885539d,left: 0.2627728687947981d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.899870083529353d,right: 0.7997265907127866d,bottom: 0.5681157970475205d,left: 0.7456175597430708d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2540500697076703d,right: 0.7387987679723476d,bottom: 0.007274208652557901d,left: 0.041241495669256945d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.909828653264084d,right: 0.9628109141487163d,bottom: 0.7032465316289982d,left: 0.5456536096502892d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5923187322373912d,right: 0.9587837890127198d,bottom: 0.22989245945824943d,left: 0.4541031300612608d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8409090853219305d,right: 0.5895205767789704d,bottom: 0.444162050969535d,left: 0.08371978299357208d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49029596627980054d,right: 0.6334304694773065d,bottom: 0.042821958086526446d,left: 0.06316422012698264d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4237649189517506d,right: 0.9229807352630569d,bottom: 0.07166728469437755d,left: 0.1963815693329054d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.10115880824734091d,right: 0.45923773570788895d,bottom: 0.03791051230328524d,left: 0.293386432381851d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5317475067860602d,right: 0.7451371073812809d,bottom: 0.5115513457588382d,left: 0.02050152090541435d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5377643174904803d,right: 0.7807219342923609d,bottom: 0.11014180016285102d,left: 0.07057332677093942d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42254364773862463d,right: 0.14051356443281215d,bottom: 0.3081967226975001d,left: 0.08036129540468107d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.26891118737289443d,right: 0.8946424162554033d,bottom: 0.25850988248327733d,left: 0.8172795116301138d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8953985692144784d,right: 0.9243840133848532d,bottom: 0.7341973413834064d,left: 0.6784614501034175d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19413775362553976d,right: 0.5853181626309525d,bottom: 0.15240536592889864d,left: 0.11610046131222351d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6113901043123533d,right: 0.5264700254541466d,bottom: 0.08315803739883432d,left: 0.08822290044708869d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44655846651311515d,right: 0.8375542939531638d,bottom: 0.36256199023677527d,left: 0.8176780796387122d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4307970844486284d,right: 0.7669156291061707d,bottom: 0.05932833787274905d,left: 0.5184185630978221d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7890325393744158d,right: 0.45484825161848397d,bottom: 0.4248332454373559d,left: 0.3530420168885222d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9920318823411917d,right: 0.5591703244322541d,bottom: 0.6745066878166053d,left: 0.49715502088881014d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4326025855935888d,right: 0.7839107673555836d,bottom: 0.02839424414930125d,left: 0.12044011904237861d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9050983178241256d,right: 0.7247775286082052d,bottom: 0.27545913464748295d,left: 0.5109932584567212d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30887685648018226d,right: 0.7130798591287955d,bottom: 0.022721271769956863d,left: 0.3575978861852478d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9791652425176568d,right: 0.16825632915024114d,bottom: 0.09255800081637866d,left: 0.15731071001934027d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.52990107609638d,right: 0.6170287750475821d,bottom: 0.0490107561027352d,left: 0.018889625162835655d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14978792473015023d,right: 0.9452046113182304d,bottom: 0.09743866171398363d,left: 0.7704347089528585d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49507389180074124d,right: 0.9700438211692511d,bottom: 0.07177150472266369d,left: 0.23104758545826842d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5179196320800077d,right: 0.2299596844038152d,bottom: 0.00363722315571835d,left: 0.0032611562846657227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9975597527370532d,right: 0.6688438185804247d,bottom: 0.6072043289008177d,left: 0.19743970383195375d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3842364035747696d,right: 0.9847725522543984d,bottom: 0.00031575477423551046d,left: 0.36034531959807203d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.395685493338775d,right: 0.7889512851200176d,bottom: 0.20033440176314832d,left: 0.29284804743225634d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5791843089276495d,right: 0.8258152872389942d,bottom: 0.3433156739794049d,left: 0.047867763982201494d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17522794357992133d,right: 0.023675191926769923d,bottom: 0.0660493648227245d,left: 0.02073887485401571d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8448181175311801d,right: 0.5780185728635934d,bottom: 0.12415729112671137d,left: 0.17054371881617014d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.11575827570260877d,right: 0.6397530911658819d,bottom: 0.051866750389991556d,left: 0.485020365604912d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7687849341560377d,right: 0.1986373976515231d,bottom: 0.3397133610487556d,left: 0.19332124855527455d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6309207454130791d,right: 0.47717793015527876d,bottom: 0.3744762807062584d,left: 0.253994446731003d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21155412177486455d,right: 0.9640947977198339d,bottom: 0.013097890264459067d,left: 0.1874558167885102d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.262228953493982d,right: 0.5603051039045361d,bottom: 0.24785580165986154d,left: 0.22340771608599552d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9152843126606096d,right: 0.9304478861223262d,bottom: 0.7167120470559001d,left: 0.7671343100758664d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8345746661675184d,right: 0.17852833604610685d,bottom: 0.8329953839456106d,left: 0.14985866325770092d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1481277000500938d,right: 0.6442513960098213d,bottom: 0.014832803796036798d,left: 0.4283295521919347d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8995966019478849d,right: 0.9741100605146127d,bottom: 0.6389252530090723d,left: 0.6169171531385154d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.20354952986591068d,right: 0.9764105525778052d,bottom: 0.09468444415863975d,left: 0.35076967733131625d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.454867838645598d,right: 0.8563566643556342d,bottom: 0.2832789464291886d,left: 0.03328947797052306d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49673243897221386d,right: 0.7373156537623762d,bottom: 0.19596899693675263d,left: 0.08256898762303744d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9637745233169213d,right: 0.6663347734620519d,bottom: 0.5849133256413999d,left: 0.43974726884026527d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6684188362128296d,right: 0.8911499817902547d,bottom: 0.12190384430935552d,left: 0.5426604406363381d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8647509531782981d,right: 0.5941521504641015d,bottom: 0.7959778599200931d,left: 0.21380790041007003d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19557011667113777d,right: 0.7174403088995596d,bottom: 0.13771128066437666d,left: 0.44682133770519183d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.60373090620908d,right: 0.18184578667596796d,bottom: 0.40873213594104474d,left: 0.15975788744039854d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47801462708986675d,right: 0.2774956551506941d,bottom: 0.3436951864297577d,left: 0.04808924898118416d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.640197462761732d,right: 0.553399029737956d,bottom: 0.47226649137519805d,left: 0.3012314652303819d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6701341349239132d,right: 0.5470972566890142d,bottom: 0.4878921302758056d,left: 0.45045398415529625d))));

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0M>(15);

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
                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

