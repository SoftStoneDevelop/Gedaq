

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6371852259188402d,

0.5245215018419036d,

0.11403531010458523d,

0.4211989962278011d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6284259321921359d,

0.7897121454244952d,

0.9266303961427647d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8672572966431523d,

0.6274257007397429d,

0.734868713849045d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23601991248231702d,

0.5980228384256014d,

0.95679533867235d,

0.4394101766252607d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1239855203455128d,

0.30487457639642124d,

0.45927429364125694d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.03560177444811563d,

0.727984066643636d,

0.3874576017504099d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3719239937864419d,

0.43047698732237505d,

0.004697222471796936d,

0.1665720597935182d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06750056174642194d,

0.06434395127716241d,

0.21150581582966888d,

0.5950717313615359d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2816971631007398d,

0.8058913088971245d,

0.4554924355576998d,

0.6031098948131479d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0004994070953521224d,

0.8716995753845582d,

0.19721336005226264d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36921055047812923d,

0.11576575616631124d,

0.513656527172101d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8462289813632409d,

0.4779779192327759d,

0.06886028015230827d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.278548927342553d,

0.11722600161941177d,

0.05015771872794916d,

0.388288446201828d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.39601801732083075d,

0.4121490687958539d,

0.9156442280236927d,

0.2781367481041095d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0012774606601209104d,

0.9452087790906983d,

0.3277303509664935d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6752824419724697d,

0.026589572526258043d,

0.0024262822722250776d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0891404370211577d,

0.27270135900156933d,

0.9913918210836611d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.019160042012661638d,

0.4700307011797723d,

0.8809843156026487d,

0.3816503357714104d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.672513909172916d,

0.8974490835807525d,

0.42626984718644045d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.927816673485414d,

0.21268667089339977d,

0.7154974075550375d,

0.8758904552938729d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1520710440392431d,

0.35240464735652155d,

0.8321390692492756d,

0.4255451335220113d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6514510786331517d,

0.4769780155830948d,

0.8054965566021662d,

0.369710222330909d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.29302397928005386d,

0.6382933615828886d,

0.48001299173984624d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.43360263735440663d,

0.5344318432161541d,

0.46104625871627336d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7061994225487098d,

0.02128558016414661d,

0.308573148712717d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.010163223210858718d,

0.3032774318727366d,

0.35727207525204385d,

0.5754621748345068d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8416757165053351d,

0.2872407040867214d,

0.993964310631676d,

0.675796202315277d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.28212097870030695d,

0.42127127641310635d,

0.23382350854773637d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05043750843120631d,

0.49696816587495574d,

0.9414031582809997d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4520383288837466d,

0.6891925659394866d,

0.8719766470544462d,

0.9455903115910189d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.020312427538565214d,

0.19381597024355923d,

0.6685270510793624d,

0.8904410476888655d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5082776672824967d,

0.43490549061562755d,

0.425656472316018d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6147847187280473d,

0.8874736292098915d,

0.2338198669126128d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2865069788302105d,

0.4946816150850618d,

0.6362135836601089d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.40057605397188145d,

0.16221832922694102d,

0.046294793197230066d,

0.07401154604380389d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20171235187590508d,

0.8928404500743992d,

0.619900326068336d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.028724082850343002d,

0.9169664881071204d,

0.9338004121280197d,

0.474661777443076d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4755542167912705d,

0.41055811344011195d,

0.42190411161516983d,

0.7723597998839073d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0577547933780046d,

0.6246991453670854d,

0.4127542526460469d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.39852275570861284d,

0.036586699085163876d,

0.8292416496126453d,

0.9155984821427336d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5711728021008422d,

0.01107537074449716d,

0.25832557157988545d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7517201647738565d,

0.7101783019790153d,

0.3804106524493145d,

0.02984069117791366d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0860686159398073d,

0.9821996794608296d,

0.006330106702337579d,

0.9772325677360492d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.22848116497230997d,

0.512285476794367d,

0.39804884596655754d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.893116673435484d,

0.1329111514439988d,

0.8967587626365023d,

0.5361571690319396d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9006311768809593d,

0.24332688564141614d,

0.6342820580920328d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33629686546538795d,

0.06418125701223798d,

0.43658908480266345d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.38908125760260626d,

0.10216829337858668d,

0.897990348836136d,

0.037931855950289584d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3347000149537608d,

0.6443685398320682d,

0.54440104730384d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.22722708060482577d,

0.4442118459464055d,

0.9548652854859886d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.37250086781631886d,

0.5488348163567291d,

0.4155153750082028d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9536959838597642d,

0.6249608337838548d,

0.09300657906138277d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.588371643759879d,

0.6520536753798095d,

0.016286190503947418d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.41810599129525194d,

0.019827947097525667d,

0.33079543464908223d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7129043359592333d,

0.0020057893075480226d,

0.3145999875049128d,

0.6184932312121819d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.025024770112765937d,

0.7271462284722072d,

0.9326624029160112d,

0.8144627103144776d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.007439980075727104d,

0.1831359514496277d,

0.19582795215618876d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4304106399076061d,

0.26818402829659704d,

0.4531049010328507d,

0.6575697794791865d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6298271629728233d,

0.43522501394025936d,

0.7365918531902714d,

0.8800366743681556d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.04376314756120325d,

0.7723073532028697d,

0.16318085871972998d,

0.6507042434037867d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9685579797657414d,

0.6342605120831172d,

0.8990348713395324d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9871084718881796d,

0.6067280511411182d,

0.5224068409138125d,

0.09892464907862986d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6504361977320972d,

0.6417889251035626d,

0.03720046720725845d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6306271778048091d,

0.9140073966762209d,

0.25653920091189863d,

0.02748424432344032d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3017806628593551d,

0.5113867319920907d,

0.6251816011630525d,

0.48625238953024996d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3253797358860825d,

0.1892147559234586d,

0.7245768099434238d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7637313672449116d,

0.8831267739316941d,

0.10519716546521907d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7918200193617145d,

0.11475223887362929d,

0.27426072773253896d,

0.7723439184641498d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 15, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 56, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 108, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

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
                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

